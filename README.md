<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
_Social buttons_

[![gotoyuriko - IOOFI](https://img.shields.io/static/v1?label=gotoyuriko&message=IOOFI&color=blue&logo=github)](https://github.com/gotoyuriko/IOOFI)
[![stars - IOOFI](https://img.shields.io/github/stars/gotoyuriko/IOOFI?style=social)](https://github.com/gotoyuriko/IOOFI)
[![forks - IOOFI](https://img.shields.io/github/forks/gotoyuriko/IOOFI?style=social)](https://github.com/gotoyuriko/IOOFI)

_Repo metadata_


[![GitHub tag](https://img.shields.io/github/tag/gotoyuriko/IOOFI?include_prereleases=&sort=semver)](https://github.com/gotoyuriko/IOOFI/releases/)
[![License](https://img.shields.io/badge/License-GNU_2.0-blue)](#license)
[![issues - IOOFI](https://img.shields.io/github/issues/gotoyuriko/IOOFI)](https://github.com/gotoyuriko/IOOFI/issues)


## License

Released under [GNU 2.0](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html) by [@gotoyuriko](https://github.com/gotoyuriko), [@Xavvyro](https://github.com/Xavvyro) and [@christjandra15](https://github.com/christjandra15).


<!-- PROJECT LOGO -->
<br />
<p align="center">
  <h3 align="center">Student Reservation Sysetm</h3>

  <p align="center">
    Visual Studio Windows Form Application
  </p>
</p>



<!-- ABOUT THE PROJECT -->
## About The Project

![Screenshot_2021-08-07_220827](https://user-images.githubusercontent.com/64601225/128603343-0c439016-ba30-47f7-914d-da46cb659266.png)
![Screenshot_2021-08-07_220856](https://user-images.githubusercontent.com/64601225/128603368-bbf5f666-06eb-4b42-8fee-4382bbbe11c2.png)
![Screenshot_2021-08-07_220924](https://user-images.githubusercontent.com/64601225/128603369-da76ad74-c7d9-4eef-9a5c-d2c2559161a4.png)
![Screenshot_2021-08-07_220947](https://user-images.githubusercontent.com/64601225/128603374-1f892882-1e50-4bc4-b4e8-af9f8d0e54b4.png)
![Screenshot_2021-08-07_221031](https://user-images.githubusercontent.com/64601225/128603378-4b1d0179-3099-42d0-a2de-52fa43295f47.png)
![Screenshot_2021-08-07_221324](https://user-images.githubusercontent.com/64601225/128603381-705c7fa3-a2e1-4267-8916-59145fec80a3.png)

As a Group Assignment for the Introduction to Object Oriented Programming, we are assigned to create a room reservation system that will be used by students and managed by the admin. The systems allow the students to be able to pick from 20 different discussion room which consists of Amber, Black Thorn, Cedar, and Daphne. The students only allowed to reserve a room 2 days prior to the desired schedule, under 2 days our system will automatically reject the request. The students also not allowed to register a room more than 6 hours, our system will automatically reject the requested date.

After registration, the students able to see the reserved room by them in the Your Reservation menu where the students able to cancel a certain room and change the room reservation time. The cancellation can be directly cancelling by the student by selecting the desired room. The change room reservation will need the admin to be able to approve and reject the change request from the student.

After the student menu, the admin menu will have 3 main form which consists of Daily Report, Monthly Report, and Pending Request. The daily report will allow the admin to search a specific date and the search system will only display the requested date of the database and displayed in the data grid view. The system also works the same with the monthly room report but instead of a specific date it uses monthly search. The last menu is the pending request, which the admin able to approve and reject a certain room change request that has been made from the students. The system will approve the change if the requested change time and date is available. The system will automatically reject if the requested time and date have already been reserved or have an overlapping time with a certain reservation.

**Contributors:**
+ @gotoyuriko Yuriko Goto
+ @Xavvyro Aurelio Darren Savero
+ @christjandra15


### Built With 

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [SQL Database](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

<!-- GETTING STARTED -->
## Getting Started

Go to the [link](https://visualstudio.microsoft.com/) and get **Visual Studio**.

### Installation

Select
+ ASP.NET and web development
+ .NET desktop development
+ Data storage and processing

### Installation

Clone the repo
```sh
git clone git@github.com:gotoyuriko/IOOFI.git
```


<!-- USAGE EXAMPLES -->
## Usage

To open the Applciation, go to `/IOOFI/DisucussionRoomReservationSystem/bin/Release` and open `DiscussionRoomReservationSystem` Application.

<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- CONTACT -->
## Contact

Yuriko Goto - email: gotoyuriko95@gmail.com

Project Link: [https://github.com/github_username/repo_name](https://github.com/github_username/repo_name)
