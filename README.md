# Animal Shelter API
_By Brad Buchholz_
## Description

_You've completed a few projects at the dev agency where you work and you've been given more autonomy to choose which project you'd like to work on next. The agency currently has three new back-end contracts to build APIs for their clients. Since this is the first time you've been given free rein on a projectm take this opportunity to showcase your versatility for the project manager._

## Technologies Used 
* C#
* dotnet
* .Net 5.0
* MYSQL
* Markdown   

## Setup / Installation 

1. Download and install **`dotnet 5.0`** on your computer. 
2. Clone the GitHub [repository](https://github.com/Bradbuchholz/AnimalShelterApi.Solution.git) onto your computer.
3. Make sure to have MySql Workbench installed on your computer.
4. Make sure to have dotnet-ef installed - this project uses **`version 5.0.1`**. I have it globally installed, but you can also install it just in this directory. 
5. Open the project in VScode or your terminal of choice. 
6. Create an `appsettings.json` file in the `AnimalShelterApi.Solution/AnimalShelter/` directory and add the following code, replacing anything in `square brackets` with the information it represents specific to the project database: 
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Debug",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[Database-Name-Here];uid=[User-ID-Here];pwd=[Your-Password-Here];"
  }
}


```
#### Example of complete appsettings.json
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Debug",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=superawesomestrongpassword;"
  }
}
```
7. Open MySql Workbench and login to your server.
8. From your terminal navigate to the `AnimalShelterApi.Solution/AnimalShelterApi` folder and run the command **`dotnet ef database update`** to create the database from migrations.
9. Next use the command **`dotnet run`** in your terminal to launch the program.
10. The API should now be available at the server address you used in the appsettings.json folder.

## API Documentation

_You can explore the API endpoints in Postman or your browser. Once the API is running you can also go to `[Your-server-address]/swagger`._
* example - `http://localhost:5001/swagger`

_This is an open API so you don't need any authentication to use all CRUB functionality._

## Endpoints
_Base URL: [http://localhost:5001]

_HTTP Request Structure_

```
GET /api/Animals
POST /api/Animals
GET /api/Animals/{id}
PUT /api/Animals/{id}
DELETE /api/Animals/{id}
```

# Example

```
http://localhost:5001/api/animals/2
```
# Example response

```
{
  "animalId": 2,
  "name": "Fluffy",
  "petType": "Cat",
  "breed": "Persian",
  "age": 4,
  "gender": "Female",
  "color": "Brown"
}
```

_Search parameters include:_

```
petType: dog, cat, bird etc...
breed: What is the breed of animal - exp. lab for a dog
minimumAge: returns results based on an age range
maxAge: returns results based on maximum age
gender: returns result based on gender preference
color: returns results based on chosen color
```

## Known Bugs 
* None. 
## License
_Copyright (c) Brad Buchholz_