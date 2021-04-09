# WpfTouchTest
A simple WPF based application to demonstrate a touch problem.

To run: 
Build on VS2019 v16.8.3 targeting .Net Framework 4.7.2.
Run on Windows 10 (I am using Windows 10 Pro 10.0.19041 Build 19041), make sure you have a touch screen that supports 10 touch device (your 10 fingers).

Run the program and you will see the window like below.

From now on please only use your fingers to tap, do not use mouse:

Step 1: Tap the top most button to pop up a MessageBox.
Step 2: While the message box is showing, tap the main window, outside the message box. Say you tap outside three times, count them as #1, #2, #3. The pop up message box blinks, which is expected.
Step 3: Now tap the pop up message box's OK or Cancel button, count as tap #4. The message box closes.
Step 4: Tap any where on the MainWindow. It is easier to tap the "Click me" buttons to see a visual update in the status bar below. Continue counting your taps, #5, #6, etc.
Step 5: When it comes to tap #11, you will find there is no response. Tap #12, no response; Tap #13 no response; Tap #14, it is back to normal!

Seems any outside message box tap in step 2 will cause a delayed non-response after 10 additional taps. This make me think maybe internally there are an array of 10 touch device handlers (10 fingers, makes sense), handling each individual touch separately, to support either single touch or multi-touch up to 10 fingers. However, in the above test case, an outside tap is not completely handled, so that after 10 more taps, the same handler is used again, but its internal status was still left in the wrong status, thus not handling this new tap properly. After this, it is reset back to normal, ready to handle the next tap, which is 10 taps away.

If my above guess is correct, I hope there could be an easy fix from Microsoft soon.
