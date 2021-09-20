-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 20, 2021 at 07:28 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `chat_room_db`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `all_comments` ()  SELECT users.name, body, date
FROM comments 
INNER JOIN users ON comments.user_id = users.user_id
WHERE date < CURRENT_DATE$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `recent_comments` ()  SELECT users.name, body, date
FROM comments 
INNER JOIN users ON comments.user_id = users.user_id
WHERE date >= CURRENT_DATE$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `user_login` (IN `na` VARCHAR(20), IN `pass` VARCHAR(10))  SELECT user_id,name,password, status, auth_type from users WHERE name = na and password = pass$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `comments`
--

CREATE TABLE `comments` (
  `id` int(15) NOT NULL,
  `user_id` int(10) NOT NULL,
  `body` varchar(1000) NOT NULL,
  `date` datetime(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `comments`
--

INSERT INTO `comments` (`id`, `user_id`, `body`, `date`) VALUES
(1, 2, 'asdasdasdasdasdasd', '2021-09-19 19:36:25.00000'),
(3, 1, 'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.', '2021-09-01 19:45:08.00000'),
(4, 2, 'asd asd asd asd asd asd asd asd asd asd asd asd asd', '2021-09-02 20:38:40.00000'),
(5, 2, 'asdasdasda asdasdasdasdad asdasdasdasd', '2021-09-08 20:39:07.00000'),
(7, 1, 'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.', '2021-09-19 21:17:28.00000'),
(8, 2, 'this is a test!', '2021-09-19 21:52:16.48500'),
(9, 6, 'este comentario es una prueba', '2021-09-19 21:52:50.06700');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(10) NOT NULL,
  `name` varchar(20) NOT NULL,
  `password` varchar(10) NOT NULL,
  `status` varchar(10) NOT NULL,
  `auth_type` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `name`, `password`, `status`, `auth_type`) VALUES
(1, 'Luis', 'abcd1234', 'ACTIVE', 'admin'),
(2, 'Jose', 'abc123', 'ACTIVE', 'user'),
(4, 'TestUser', 'asd123', 'ACTIVE', 'user'),
(6, 'Gaby', 'cachimba', 'ACTIVE', 'user');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `comments`
--
ALTER TABLE `comments`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `comments`
--
ALTER TABLE `comments`
  MODIFY `id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
