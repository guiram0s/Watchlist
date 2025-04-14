# 🎬 Watchlist

An IMDb-inspired web application that allows users to explore and manage a personalized watchlist of movies.

---

## 🛠 Technologies Used

- **PHP**: Backend scripting language for server-side logic.
- **C#**: Utilized in certain components for backend services or integrations.
- **JavaScript**: Enhances interactivity and dynamic content on the client side.
- **CSS**: Styles the application, ensuring a responsive and visually appealing interface.
- **SQL**: Manages and queries the relational database for storing user and movie information.

---

## 🗂 Project Structure

The project comprises several key files and directories:

- **`assets/`**: Contains static resources like images, stylesheets, and scripts.
- **`Filmes.php`**: Manages movie-related functionalities, possibly displaying movie lists or details.
- **`InfoPage.php`**: Displays detailed information about a specific movie.
- **`Movie.php`**: Defines the `Movie` class, encapsulating movie attributes and behaviors.
- **`User.php`**: Defines the `User` class, handling user-related data and operations.
- **`Utilizadores.php`**: Manages user-related functionalities, such as displaying user lists or profiles.
- **`index.php`**: The main entry point of the application, likely displaying the homepage.
- **`ligaBD.php`**: Handles database connection and related operations.
- **`login.php`**: Manages user authentication and login processes.
- **`sair.php`**: Handles user logout functionality.
- **`validar.php`**: Validates user inputs and sessions.

---

## 🔑 Key Features

- **User Authentication**: Users can register, log in, and manage their profiles.
- **Movie Exploration**: Browse and search for movies to add to a personal watchlist.
- **Personalized Watchlist**: Users can curate a list of movies they intend to watch.
- **Movie Details**: View comprehensive information about each movie, including synopsis, cast, and ratings.

---

## 🧩 Code Architecture & Design Patterns

The project employs several design principles:

- **Separation of Concerns**: Different files handle specific functionalities, promoting modularity and maintainability.
- **Object-Oriented Programming (OOP)**: Utilizes classes like `Movie` and `User` to encapsulate data and related methods.
- **MVC-Like Structure**: While not a strict MVC framework, the project separates data handling (`Movie.php`, `User.php`), presentation (`index.php`, `InfoPage.php`), and control logic (`Filmes.php`, `Utilizadores.php`).

---

## 🚀 Getting Started

### 1. Clone the Repository

``bash
`git clone https://github.com/guiram0s/Watchlist.git`

### 2. Set Up the Database

Create a new SQL database.

Import the provided SQL schema and data.

### 3. Configure Database Connection
   
Update ligaBD.php with your database credentials:

$servername = "your_server";
$username = "your_username";
$password = "your_password";
$dbname = "your_database";

### 4. Deploy the Application

Place the project files in your web server’s root directory:

htdocs for XAMPP

www for WAMP

Start your web server and database service (e.g., Apache + MySQL).

Access the app in your browser at:

http://localhost/Watchlist

## Some ScreenShots from the App

<p><strong>Login Screen</strong><br>
<img src="https://github.com/user-attachments/assets/8448895e-423b-4b85-b77e-2aa42f9504e5" width="250">
</p>

<p><strong>Admin WebPage to manage Users</strong><br>
<img src="https://github.com/user-attachments/assets/f0f10af3-f12b-4a08-af63-5ffd143bd1c8" width="500">
</p>

<p><strong>Admin WebPage to manage movies</strong><br>
<img src="https://github.com/user-attachments/assets/9d25f00e-2848-4b44-bde2-c363a54f9ea5" width="500">
</p>

<p><strong>Admin WebPage to add movies</strong><br>
<img src="https://github.com/user-attachments/assets/f0c1b102-0dd0-475a-8e06-8160829e092f" width="500">
</p>

<p><strong>App Main Menu</strong><br>
<img src="https://github.com/user-attachments/assets/7afbf3c2-38ed-47a6-a91b-29cb64a8dcb4" width="500">
</p>

<p><strong>App Movie Menu</strong><br>
<img src="https://github.com/user-attachments/assets/a56104e1-bacf-48e9-ad3e-1a71d0d46e77" width="500">
</p>

<p><strong>App User WatchList Menu</strong><br>
<img src="https://github.com/user-attachments/assets/63fd3c95-1728-494b-89eb-a68bae2fcd2d" width="500">
</p>

