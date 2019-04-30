-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Vært: 127.0.0.1
-- Genereringstid: 30. 04 2019 kl. 18:55:02
-- Serverversion: 10.1.34-MariaDB
-- PHP-version: 7.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `users`
--

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `bankusers`
--

CREATE TABLE `bankusers` (
  `username` varchar(255) NOT NULL,
  `RFID` int(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `balance0` double NOT NULL,
  `balance1` double NOT NULL,
  `balance2` double NOT NULL,
  `balance3` double NOT NULL,
  `balance4` double NOT NULL,
  `balance5` double NOT NULL,
  `balance6` double NOT NULL,
  `balance7` double NOT NULL,
  `balance8` double NOT NULL,
  `balance19` double NOT NULL,
  `accounts` int(10) NOT NULL,
  `lastlogin` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `ID` int(11) NOT NULL,
  `full_name` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Data dump for tabellen `bankusers`
--

INSERT INTO `bankusers` (`username`, `RFID`, `password`, `balance0`, `balance1`, `balance2`, `balance3`, `balance4`, `balance5`, `balance6`, `balance7`, `balance8`, `balance19`, `accounts`, `lastlogin`, `ID`, `full_name`, `email`) VALUES
('s?ren', 0, '1234', 1000, 1500, 0, 0, 0, 0, 0, 0, 0, 0, 1, '2018-02-26 22:07:50', 1, 'S?ren S?rensen', 'e?ren@s?ren.com'),
('emil9280', 0, '96859685', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, '2018-02-26 23:13:24', 2, 'Emil H?rstrup M?ller', 'emil-h-m@live.dk'),
('lime800', 0, '96859685', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '2018-03-16 21:32:10', 3, 'Emil H?rstrup M?ller', 'emi@ligd.dk'),
('emil92800', 0, '9685', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '2018-08-14 17:59:24', 4, 'emil92800', '9685');

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `bankusers`
--
ALTER TABLE `bankusers`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID` (`ID`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `bankusers`
--
ALTER TABLE `bankusers`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
