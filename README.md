# PasswortTSLock
PasswortTSLock is a simple script that prompts the user for a password before continuing to execute the Task Sequence (TS) in Microsoft Deployment Toolkit (MDT). This can be useful for securing your deployment process and ensuring that only authorized users can access and run the code.

## Getting Started
To get started with PasswortTSLock, follow these steps:

Download the script from this repository.
Place the script in the "Scripts" folder of your MDT deployment share.
Add a new "Run Command Line" step to your TS, and set the command line to:
Edit
Full Screen
Copy code
cmd.exe /c X:\DeploymentShare\Scripts\PasswortTSLock.cmd
Set the "Start in" field to:
Edit
Full Screen
Copy code
X:\DeploymentShare\Scripts
Configure the password for the script by editing the "password.ini" file in the "Scripts" folder.
Configuration
PasswortTSLock can be configured by editing the "password.ini" file in the "Scripts" folder. The file should contain a single line with the desired password.

## Usage
PasswortTSLock will prompt the user for the password specified in the "password.ini" file. If the correct password is entered, the script will exit with a return code of 0, and the TS will continue to execute. If the incorrect password is entered, the script will exit with a return code of 1, and the TS will stop executing.

## Troubleshooting
If you encounter any issues with PasswortTSLock, make sure that the script is located in the correct folder and that the password specified in the "password.ini" file is correct.

## Support
If you need help with PasswortTSLock, please open an issue in this repository.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
PasswortTSLock is released under the MIT License. See LICENSE for details.

## Authors and acknowledgment
@generalsle1n
