# _University Registrar_

#### _In Class project for Week 5 of C# Unit at Epicodus_, _March 23, 2020_

#### By _**Patrick Kille, Matt Taylor, Drake Wilcox, Dominique Youmans**_

## Description
 __

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:| 
||||


## Setup/Installation Requirements
_Make sure you have these tools installed on your computer:_
*  [Git version control](https://git-scm.com/downloads)
*  [MySql](https://azure.microsoft.com/en-us/free/mysql/)
*  [Microsoft .Net Core 2.2](https://docs.microsoft.com/en-us/dotnet/framework/install/)
*  [.Net Script](https://dotnet.microsoft.com/download/dotnet-core/2.2)


_In Terminal:_

* Using your terminal navigate to where you want to save this project by typing:
```sh
cd desktop
```

* Clone the file from GitHub by typing:
```sh
git clone  https://github.com/drakewilcox/HairSalon.Solution.git
```

* Navigate to the project folder by typing:
```sh
cd HairSalon.Solution/HairSalon
```
* Restore the project with this terminal command:
```sh
dotnet restore
```

* Open up MySql in your terminal with this command (do not include curly brackets):
```sh
mysql -uroot -p{your password}
```

* Create a new table by typing:
```sh
CREATE DATABASE drake_wilcox;
```

* Open your new database by typing:
```sh
USE drake_wilcox;
```

* Create Stylist table by typing:
```sh
CREATE TABLE `stylists` (
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Specialty` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
);
```
* Create Clients table by typing:
```sh
CREATE TABLE `clients` (
  `ClientId` int(11) NOT NULL AUTO_INCREMENT,
  `StylistId` int(11) DEFAULT '0',
  `Name` varchar(255) DEFAULT NULL,
  `PhoneNumber` varchar(255) DEFAULT NULL,
  `HairStyle` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ClientId`)
);
```
* Now exit MySql by typing:
```sh
exit;
```
* Then start the webserver by typing:
```sh
dotnet run
```
* Open your web browser and navigate to localhost:5000
```sh
http://localhost:5000/
```
* If your setup worked you should see a homepage with a navbar and photo. 

**Note: To exit, simply press**
```sh
Ctrl + C
```

## Known Bugs

_No known bugs at this time._

## Support and contact details

This tool is provided as is. 

## Technologies Used
* [_Git_](https://git-scm.com/downloads)
* [_C#_](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [_.NET Core 2.2_](https://docs.microsoft.com/en-us/dotnet/framework/install/)
* [_dotnet script_](https://github.com/filipw/dotnet-script)
* [_Asp.Net Core 2.2 MVC_](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-3.1&tabs=visual-studio)
* [_Visual Studio Code_](https://code.visualstudio.com/)
* [MySQL 8.0.15](https://downloads.mysql.com/archives/community/)
* [MySQL Workbench 8.0.15](https://downloads.mysql.com/archives/workbench/)
* [Entity Core framework](https://docs.microsoft.com/en-us/ef/)
* [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Patrick Kille, Matt Taylor, Drake Wilcox, Dominique Youmans_**


46074403+21-Coding@users.noreply.github.com