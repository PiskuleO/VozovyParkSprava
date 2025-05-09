-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Pát 09. kvě 2025, 18:24
-- Verze serveru: 10.4.32-MariaDB
-- Verze PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáze: `vozovy_park`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `vozidla`
--

CREATE TABLE `vozidla` (
  `Id` int(11) NOT NULL,
  `SPZ` varchar(10) NOT NULL,
  `Model` varchar(50) DEFAULT NULL,
  `Vyrobce` varchar(50) DEFAULT NULL,
  `Rok` int(11) DEFAULT NULL,
  `Stav` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `vozidla`
--

INSERT INTO `vozidla` (`Id`, `SPZ`, `Model`, `Vyrobce`, `Rok`, `Stav`) VALUES
(1, '1AB2345', 'Octavia', 'Škoda', 2018, 'Nový'),
(2, '2CD3456', 'Golf', 'Volkswagen', 2017, 'Použitý'),
(4, '4GH5678', 'Passat', 'Volkswagen', 2019, 'Použitý'),
(5, '5IJ6789', 'A3', 'Audi', 2021, 'Nový'),
(6, '6KL7890', 'Focus', 'Ford', 2018, 'Použitý'),
(7, '7MN8901', 'Civic', 'Honda', 2020, 'Nový'),
(8, '8OP9012', 'Corolla', 'Toyota', 2021, 'Nový'),
(9, '9QR0123', 'Tiguan', 'Volkswagen', 2022, 'Nový'),
(10, '10ST1234', 'Superb', 'Škoda', 2017, 'Použitý'),
(11, '11UV2345', 'Q7', 'Audi', 2019, 'Použitý'),
(12, '12WX3456', 'S-Max', 'Ford', 2018, 'Použitý'),
(13, '13YZ4567', 'Kuga', 'Ford', 2020, 'Nový'),
(14, '14ZA5678', '320i', 'BMW', 2019, 'Použitý'),
(15, '15AB6789', 'X5', 'BMW', 2021, 'Nový'),
(16, '16BC7890', 'A4', 'Audi', 2018, 'Použitý'),
(17, '17CD8901', 'Yaris', 'Toyota', 2020, 'Nový'),
(18, '18DE9012', 'Q5', 'Audi', 2017, 'Použitý'),
(19, '19EF0123', 'i30', 'Hyundai', 2021, 'Nový'),
(20, '20FG1234', 'Kodiaq', 'Škoda', 2022, 'Nový');

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `vozidla`
--
ALTER TABLE `vozidla`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT pro tabulky
--

--
-- AUTO_INCREMENT pro tabulku `vozidla`
--
ALTER TABLE `vozidla`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
