# 1-click action with teXXmo IoT Button

This is a fun project using the teXXmo IoT button given out at //build/ 2018 at the Azure IoT developer session. Using this button, several components of the Azure IoT developer platform were explored. In this particular project, the button was used to initiate an email message to a specific reciepeint
using http signals to detect click events and trigger the logic hosted in Azure. In addition, the IoT Hub is connected to Time Series Inights to have a graphical representation of the click-events as a function of time.


## Getting Started

IoT is the notion of connecting things by taking compute and connectivity, everywhere. These comprise of things that are connected and then the events from those things that are recorded somewhere, which is the cloud. For this project, the teXXmo 
button is the "thing" that is connected while the act of clicking the button is the event that is recorded in the cloud. The action from the click is the logic that is hosted in the cloud and a set of actions can help in gaining insights. 

While this is the uber picture that gets split into events, actions, and insights, below are some details on setup.

### Prerequisites

This project uses Visual Studio C# code to process the click event from the button and then uses that event to invoke the logic to output an action. Following are the prerequisite setup required:

1. Install the latest version of Visual Studio with Cloud workload 
2. Sign-up for Azure subscription 
3. Setup IoT Hub and document the resource name, connection strings etc. in a OneNote page
4. Point the teXXmo IoT Button to the IoT Hub endpoint created in prerequisite #3 
5. Plan ahead on what the action is and then setup the logic using the logic app in Azure Portal

## Documentation Referred

Several documentaion for the IoT teXXmo button is available, but following are some of the documentations used: 

1. Setup the teXXmo Button (NOTE: JSON is not needed for this project) - https://catalog.azureiotsolutions.com/details?title=teXXmo-IoT-Button&source=home-page
2. Create an IoT Hub endpoint - https://azure.microsoft.com/en-us/resources/samples/azure-serverless-iot-button/
3. Installing Visual Studio with Cloud workload - https://docs.microsoft.com/en-us/azure/azure-functions/functions-develop-vs#check-your-tools-version
4. Create the Azure Function - https://azure.microsoft.com/en-us/resources/samples/azure-serverless-iot-button/
5. Create Azure Logic App - https://azure.microsoft.com/en-us/resources/samples/azure-serverless-iot-button/

## Acknowledgments

* The Azure IoT Dev team; Jill, Prassana, and Brian 
* Inspiration from Sam, Director of Azure IoT
* Personal experience from previous employer and research
