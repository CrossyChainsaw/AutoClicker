# Auto Clicker
Auto Clicker is an application wherein you can simulate certain actions on a pc. Here are the key functionalities 
- Simulate a Mouse Click anywhere on the screen
- Simulate certain Key presses
- Simluate Key Combinations like CTRL+C / CTRL+V
- Set the Delay between Actions
- Save and Load a List of actions
- Repeat your order multiple times

## Video of me using AutoClicker
https://user-images.githubusercontent.com/74303221/174445252-d679ab56-0c1f-41cd-80f4-f5246094db82.mp4

## How to Setup
When you run the application you are confronted with this screen.

![image](https://user-images.githubusercontent.com/74303221/173813153-67ecc707-6973-43d9-9168-23ab96d50d40.png)

### Point
On your screen you see `Point 1`. `Point 1` has an x coordinate and a y coordinate. This is basically the location on your screen. `x: 0 y: 0` is the coordinate for the upper left corner of your screen. To change point location click on `Set Location`

![image](https://user-images.githubusercontent.com/74303221/173814077-0aa88c4a-13c1-4dd5-9cb2-7b478e472c66.png)

After you've clicked on the `Set Location` button, you click somewhere on your screen but NOT on the application window. If you clicked somewhere on your screen, and your application window minimized in the process, your point location should update.

*I clicked at the left edge on my screen, this should keep x at zero and give y a higher value.*
![image](https://user-images.githubusercontent.com/74303221/173814633-1f3b74d1-1af1-4c03-81d9-615ad14918db.png)

### Delay
The `Delay` variable is how much time first has to pass before the action gets done. In the example below my program will wait 10 seconds, and after waiting 10 seconds the program will simulate my desired click on the given location.

![image](https://user-images.githubusercontent.com/74303221/173815165-929d2a22-ad35-4119-a0b9-1f590fecd702.png)

### Add Multiple Points
You can add multiple points simply by pressing on the `Add` button.

![image](https://user-images.githubusercontent.com/74303221/173815485-350fd1a7-6d20-4881-b1f2-13d435892f6a.png)

Now you can setup multiple points.

![image](https://user-images.githubusercontent.com/74303221/173815538-03321f32-178d-4bfb-a170-ed8445d50e16.png)


### Repetitions
Repetitions is the amount of times the entire list of points will happen.

### How to Save
In the folder there is a SaveFile.txt this is the file everything gets saved to, but also loaded from. If you want multiple saves you manually have to extract the save to another file.

