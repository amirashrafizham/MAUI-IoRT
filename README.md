# :video_game: Blazor MAUI Robotics IoT Cross-Platform Dashboard

## :thought_balloon: About
This is a MAUI - Blazor WebAssembly dashboard project and allows the user to remotely control a robot through:
   - A desktop app [MacOS]
   - A mobile app [Android]

## :film_strip: Demo

<h6>Controlling the rover from a Desktop app</h6>

   
<h6>Controlling the rover from a Mobile app</h6>
   

### Features to be added in future release  

N/A

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/rainbow.png)

## :hammer_and_wrench: Tech Stack
| Technology          | Remarks                                                                                          |
|---------------------|--------------------------------------------------------------------------------------------------|
| Blazor MAUI         |  A cross-platform framework to build the desktop and mobile app                                  |
| RaspberryPi         |  Server to host the Web and to host the Azure DevOps agent for CICD                              |
| Pi-Top Robotics Kit |  Hardware to maneuver the robot by Pi-Top - Pi-Top OS is used to integrate with the peripherals  |


![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/rainbow.png)

## :fireworks: Installation
### Hardware 

The following hardware is required prior to installing the software
1. RaspberryPi 4B+ 
2. Pi-Top Robotics Kit

### Software

1. Run the following to install Dotnet MAUI: `dotnet workload install maui` and `dotnet tool install -g redth.net.maui.check`  
2. Run the following docker command to run in a MacOS app: `dotnet build -t:Run -f net7.0-maccatalyst`
3. Run the following command to run in an Android app:
   - open Visual Studio
   - navigate to Tools > Device Manager
   - start Pixel a5 simulator
   - `dotnet build -t:Run -f net7.0-android`

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/rainbow.png)

## :computer: Code Structure

### Platforms

##### **Robot Control Panel - Component to manoeuvre the robot**


### Libraries
 
1. Radzen Blazor library

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/rainbow.png)


## :rocket:	CICD

N/A

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/rainbow.png)

## :artificial_satellite: Connectivity


  
![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/rainbow.png)







