<a name="readme-top"></a>


<!-- PROJECT LOGO -->
<br />
<div align="center">

<h3 align="center">Schedule Application</h3>

  <p align="center">
    A basic scheduling application created in windows forms with C# and a MySQL database
    <br />
    <a href="https://github.com/Jatkerson/Schedule-Application"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    ·
    <a href="https://github.com/Jatkerson/Schedule-Application/issues">Report Bug</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>


<!-- ABOUT THE PROJECT -->
## About The Project

<p align="left">
    The scheduling application is a customizable application designed to allow users to schedule, modify, remove and track appointments with customers as well as add, modify and remove customers. The application requires a user login which references the user table. Appointment times are saved in GMT and converted based on the local client time.
  
    The project includes an ERD to document the database structure.
</p>

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- GETTING STARTED -->
## Getting Started

Beware that attempting to update the existing customer appointments will cause an error. The existing appointment data is for testing purposes and should be deleted to ensure stability.

To get a local copy up and running follow these simple example steps.


### Prerequisites

Ensure you have a local MySQL server, connector and workbench set up
* MySQL workbench is one option
  ```sh
  https://dev.mysql.com/downloads
  ```

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/Jatkerson/Schedule-Application.git
   ```
   
2. Use the data.sql file to import the database with your database management tool

3. Update App.config file by replacing the Username and Password values of the connectionString with the username and password for your local MySQL server

4. The default login information when launching the application is username "test" and password "test"


<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

James Atkerson - jatkerson54@gmail.com

Project Link: [https://github.com/Jatkerson/Schedule-Application](https://github.com/Jatkerson/Schedule-Application)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/james-atkerson
