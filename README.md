# PCHueController

<p align="center">
<a href="https://www.microsoft.com/net"><img src="https://img.shields.io/badge/.NET%20Framework-4.6.1-orange.svg" style="max-height: 300px;"></a>
<img src="https://img.shields.io/badge/Platform-.NET Forms-lightgrey.svg" style="max-height: 300px;" alt="Platform: Windows">
</p>

## About

This is a Hue Lights controller for use with pc instead of mobile as i personally don't have my phone internet on 24/7 and for people who don't own an alexa or google home this is an easier method that doesn't require use of your phone.

## Features

* Change lights to a basic colour.
* Toggle between custom scenes (decided that i had no need for the deafult scenes) 
* Ability to choose which hub to connect to and which light to control with ability to select all lights at once
* Features ability to enable color loop as well as a custom disco mode.

## Possible to do list 

* Make disco feature two buttons to turn on and off instead of being forced to turn lights off,switch scene or choose new
colour
* Toggle for showing all scenes

## How to use

* **This program is numbered, however for completeness**:

* First select a hub from the list, the first hub will be auto selected for you
* Then either register with the hub using an app name and a device name, these can be anything as far as i am aware; they are mostly for readablity when you view your hubs list of authorised devices. After doing so you will recieve a key, 
please keep this safe or you will need to register again.The other option is to connect using the key you just recieved or an existing one.
* Once you are connected you can then choose your light/s and either set them to a generic colour, 
choose a scene or turn them on and off. The colour options won't look 100% the same this is an issue with using an 
existing colour palette as i didn't want to invest too much time into making my own. The scenes also only display 
custom scenes at the moment, this can be changed however the names won't make much sense so it then becomes a lottery draw.
If you would like to show all scenes anyway then line 256 in PCHueController.cs needs to be changed to `scenes = client.GetScenesAsync().Result;`.

## Installation

Download/Clone the repo and grab the debug/bin folder, as long as you have all of the files within this folder double click the the .exe to run the program. However feel free to fork/clone this repo or build the program for yourself instead of using 
the bin folder.

## Issues

If you come across any issues while using this program or have any suggestions, feel free to create an issue with as much information as you can.

## Dependencies

* Hue Hub & lights hardware
* Q42.HueApi v3.6.7 ([nuget link](https://www.nuget.org/packages/Q42.HueApi/3.6.7)) ([GitHub](https://github.com/Q42/Q42.HueApi))
* Q42.HueApi.ColorConverters v3.6.2 ([nuget link](https://www.nuget.org/packages/Q42.HueApi.ColorConverters/3.6.2)) ([GitHub](https://github.com/Q42/Q42.HueApi))

## License

This project is available under the MIT license. See the LICENSE file for more info.

