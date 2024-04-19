-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 19, 2024 at 02:22 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ok`
--

-- --------------------------------------------------------

--
-- Table structure for table `banque`
--

CREATE TABLE `banque` (
  `idBanque` int(11) NOT NULL,
  `nom` varchar(20) NOT NULL,
  `NumeroDeCompte` varchar(20) NOT NULL,
  `Location` varchar(20) NOT NULL,
  `Contact` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `banque`
--

INSERT INTO `banque` (`idBanque`, `nom`, `NumeroDeCompte`, `Location`, `Contact`) VALUES
(2324, 'rtyu', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `compte`
--

CREATE TABLE `compte` (
  `idCompte` varchar(20) NOT NULL,
  `typeCompte` varchar(20) NOT NULL,
  `solde` int(20) NOT NULL,
  `idBanque` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `compte`
--

INSERT INTO `compte` (`idCompte`, `typeCompte`, `solde`, `idBanque`) VALUES
('2323', 'rtyu', 3333, 'compte courant'),
('we', 'compte-titre', 23, 'rtyu'),
('wew', 'rtyu', 23, 'compte-titre');

-- --------------------------------------------------------

--
-- Table structure for table `historique`
--

CREATE TABLE `historique` (
  `idHistorique` int(11) NOT NULL,
  `Action` varchar(50) NOT NULL,
  `Date` datetime NOT NULL,
  `idUtilisateur` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `operation`
--

CREATE TABLE `operation` (
  `idOperation` varchar(20) NOT NULL,
  `idCompte` varchar(30) NOT NULL,
  `Libele` varchar(30) NOT NULL,
  `Fond` int(20) NOT NULL,
  `TypeOperation` varchar(20) NOT NULL,
  `Date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `operation`
--

INSERT INTO `operation` (`idOperation`, `idCompte`, `Libele`, `Fond`, `TypeOperation`, `Date`) VALUES
('223we', '2323', 'wew', 12, 'Retrait', '2024-04-19 10:44:48'),
('23', '2323', '23', 23, 'Retrait', '2024-04-19 09:05:00'),
('asw', '2323', 'we', 12, 'Retrait', '2024-04-19 10:50:12'),
('bv', '2323', 'cc', 23000, 'Virement', '2024-04-19 10:30:16'),
('bvc', '2323', '34', 34443, 'Virement', '2024-04-19 10:22:31'),
('mn', '2323', 'www', 230000, 'Virement', '2024-04-19 10:28:59'),
('nhn', '2323', 'sds', 23000, 'Virement', '2024-04-19 10:36:34'),
('sd', '2323', 'we', 23000, 'Virement', '2024-04-19 10:26:20'),
('swq', '2323', 'sdd', 23000, 'Virement', '2024-04-19 10:27:09'),
('sws', '2323', 'd', 22, 'Virement', '2024-04-19 10:21:10'),
('we', '2323', 'we', 23, 'Virement', '2024-04-04 10:19:22'),
('wq', '2323', 'q', 12, 'Retrait', '2024-04-19 10:50:47');

-- --------------------------------------------------------

--
-- Table structure for table `profile`
--

CREATE TABLE `profile` (
  `id` int(11) NOT NULL,
  `nom` varchar(20) NOT NULL,
  `Salaire` int(20) NOT NULL,
  `privileges` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `profile`
--

INSERT INTO `profile` (`id`, `nom`, `Salaire`, `privileges`) VALUES
(1, 'Directeur Generale', 2300000, 'ALL'),
(2, 'Directeur Generale', 2300000, 'ALL');

-- --------------------------------------------------------

--
-- Table structure for table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `idUtilisateur` varchar(20) NOT NULL,
  `nom` varchar(20) NOT NULL,
  `prenom` varchar(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `motDePasse` varchar(20) NOT NULL,
  `idProfille` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `utilisateur`
--

INSERT INTO `utilisateur` (`idUtilisateur`, `nom`, `prenom`, `username`, `motDePasse`, `idProfille`) VALUES
('e466', 'er', 'er', 'admin', '1234', ''),
('we443', 'er', 'ert', 'admin', '1234', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `banque`
--
ALTER TABLE `banque`
  ADD PRIMARY KEY (`idBanque`);

--
-- Indexes for table `compte`
--
ALTER TABLE `compte`
  ADD PRIMARY KEY (`idCompte`);

--
-- Indexes for table `historique`
--
ALTER TABLE `historique`
  ADD PRIMARY KEY (`idHistorique`);

--
-- Indexes for table `operation`
--
ALTER TABLE `operation`
  ADD PRIMARY KEY (`idOperation`),
  ADD KEY `idOperation` (`idCompte`);

--
-- Indexes for table `profile`
--
ALTER TABLE `profile`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`idUtilisateur`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `banque`
--
ALTER TABLE `banque`
  MODIFY `idBanque` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2325;

--
-- AUTO_INCREMENT for table `historique`
--
ALTER TABLE `historique`
  MODIFY `idHistorique` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `profile`
--
ALTER TABLE `profile`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `operation`
--
ALTER TABLE `operation`
  ADD CONSTRAINT `idOperation` FOREIGN KEY (`idCompte`) REFERENCES `compte` (`idCompte`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
