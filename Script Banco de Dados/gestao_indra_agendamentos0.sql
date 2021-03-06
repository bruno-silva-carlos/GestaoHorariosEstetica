-- MySQL dump 10.13  Distrib 8.0.24, for Win64 (x86_64)
--
-- Host: localhost    Database: gestao_indra
-- ------------------------------------------------------
-- Server version	8.0.24

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `agendamentos`
--

DROP TABLE IF EXISTS `agendamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `agendamentos` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ProfissionalId` int NOT NULL,
  `ServicoId` int NOT NULL,
  `ClienteId` int NOT NULL,
  `SituacaoAgendamentoId` int NOT NULL,
  `Horario` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Agendamentos_ClienteId` (`ClienteId`),
  KEY `IX_Agendamentos_ProfissionalId` (`ProfissionalId`),
  KEY `IX_Agendamentos_ServicoId` (`ServicoId`),
  KEY `IX_Agendamentos_SituacaoAgendamentoId` (`SituacaoAgendamentoId`),
  CONSTRAINT `FK_AGENDAMENTOS_CLIENTES` FOREIGN KEY (`ClienteId`) REFERENCES `pessoasfisicas` (`Id`),
  CONSTRAINT `FK_AGENDAMENTOS_PROFISSIONAIS` FOREIGN KEY (`ProfissionalId`) REFERENCES `pessoasfisicas` (`Id`),
  CONSTRAINT `FK_AGENDAMENTOS_SERVICOS` FOREIGN KEY (`ServicoId`) REFERENCES `servicos` (`Id`),
  CONSTRAINT `FK_AGENDAMENTOS_SITUACAO` FOREIGN KEY (`SituacaoAgendamentoId`) REFERENCES `situacaoagendamentos` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agendamentos`
--

LOCK TABLES `agendamentos` WRITE;
/*!40000 ALTER TABLE `agendamentos` DISABLE KEYS */;
INSERT INTO `agendamentos` VALUES (1,2,1,1,3,'2021-05-04 10:34:42.000000'),(2,2,1,1,2,'2021-05-05 10:34:42.000000'),(3,2,1,1,2,'2021-05-06 10:34:42.000000'),(4,2,1,1,2,'2021-05-07 10:34:42.000000'),(5,2,1,1,2,'2021-05-08 10:34:42.000000'),(6,2,2,1,3,'2021-05-25 22:30:00.000000'),(7,2,1,1,2,'2021-05-25 23:30:00.000000'),(8,2,1,1,2,'2021-05-25 00:00:00.000000'),(9,1,1,1,2,'2021-06-01 17:35:00.000000'),(10,1,1,1,2,'2021-06-02 18:20:00.000000'),(11,1,1,1,2,'2021-06-01 18:30:00.000000'),(12,1,1,1,2,'2021-06-03 10:50:00.000000'),(13,1,4,3,2,'2021-06-10 08:00:00.000000'),(14,6,2,20,1,'2021-06-11 13:07:00.000000'),(15,3,1,4,3,'2021-06-10 11:30:00.000000'),(16,6,2,20,1,'2021-06-12 13:10:00.000000'),(17,2,2,4,1,'2021-06-12 12:35:00.000000'),(18,7,1,4,1,'2021-07-13 11:45:00.000000'),(21,1,1,1,1,'2021-06-14 10:00:00.000000'),(22,6,2,1,1,'2021-06-14 17:00:00.000000'),(24,16,1,4,1,'2022-06-10 11:30:00.000000'),(25,10,4,4,1,'2021-06-13 12:30:00.000000'),(26,6,1,4,1,'2021-06-11 08:45:00.000000'),(27,10,4,4,1,'2021-06-12 15:30:00.000000'),(28,6,2,20,1,'2021-06-20 10:10:00.000000');
/*!40000 ALTER TABLE `agendamentos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-25 17:31:42
