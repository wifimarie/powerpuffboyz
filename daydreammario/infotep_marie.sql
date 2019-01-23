-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 23-01-2019 a las 17:18:30
-- Versión del servidor: 10.1.37-MariaDB
-- Versión de PHP: 7.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `infotep_marie`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `datos_estudiantes`
--

CREATE TABLE `datos_estudiantes` (
  `ID` int(2) NOT NULL,
  `Nombre` varchar(15) COLLATE utf8mb4_spanish_ci NOT NULL,
  `Edad` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `datos_estudiantes`
--

INSERT INTO `datos_estudiantes` (`ID`, `Nombre`, `Edad`) VALUES
(42, 'marue', 18),
(12, 'lopo', 12);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facebook`
--

CREATE TABLE `facebook` (
  `Id` int(5) NOT NULL,
  `nombre_usuario` varchar(10) COLLATE utf8mb4_spanish_ci NOT NULL,
  `nombre` varchar(5) COLLATE utf8mb4_spanish_ci NOT NULL,
  `apellido` varchar(2) COLLATE utf8mb4_spanish_ci NOT NULL,
  `sexo` varchar(1) COLLATE utf8mb4_spanish_ci NOT NULL,
  `fecha_nacimiento` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Volcado de datos para la tabla `facebook`
--

INSERT INTO `facebook` (`Id`, `nombre_usuario`, `nombre`, `apellido`, `sexo`, `fecha_nacimiento`) VALUES
(2, 'mark', 'marco', 'gu', 'm', '2019-01-23'),
(2, 'mark', 'marco', 'gu', 'm', '2019-01-23'),
(1, 'mulio02', 'mulio', 'mo', 'f', '2019-01-23'),
(1, 'mulio02', 'mulio', 'mo', 'f', '2019-01-23');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
