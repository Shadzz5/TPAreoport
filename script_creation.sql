DROP DATABASE IF EXISTS vols;
CREATE DATABASE vols DEFAULT CHARSET UTF8MB4;
USE vols;
CREATE TABLE aeroport (
    identifiant INT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    nom VARCHAR(50),
    codeAITA CHAR(3),
    identifiantVille INT UNSIGNED
) ENGINE = INNODB;
CREATE TABLE modele (
    identifiant INT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    `version` VARCHAR(50),
    nombreMoteurs TINYINT,
    identifiantConstructeur INT UNSIGNED
) ENGINE = INNODB;
CREATE TABLE constructeur (
    identifiant INT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    nom VARCHAR(50)
) ENGINE = INNODB;
CREATE TABLE ville (
    identifiant INT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    nom VARCHAR(50),
    identifiantPays TINYINT UNSIGNED
) ENGINE = INNODB;
CREATE TABLE pays (
    identifiant TINYINT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    nom VARCHAR(50)
) ENGINE = INNODB;
CREATE TABLE compagnie (
    identifiant INT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    nom VARCHAR(50)
) ENGINE = INNODB;
CREATE TABLE avion (
    identifiant INT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    nom VARCHAR(50),
    identifiantModele INT UNSIGNED
) ENGINE = INNODB;
CREATE TABLE vol (
    identifiant INT UNSIGNED PRIMARY KEY KEY,
    identifiantAeroportProvenance INT UNSIGNED,
    identifiantAeroportDestination INT UNSIGNED,
    identifiantCompagnie INT UNSIGNED,
	`code` VARCHAR(10),
    duree INT,
    identifiantAvion INT UNSIGNED
) ENGINE = INNODB;
ALTER TABLE aeroport
ADD FOREIGN KEY (identifiantVille) REFERENCES ville(identifiant);
ALTER TABLE ville
ADD FOREIGN KEY (identifiantPays) REFERENCES pays(identifiant);
ALTER TABLE modele
ADD FOREIGN KEY (identifiantConstructeur) REFERENCES constructeur(identifiant);
ALTER TABLE avion
ADD FOREIGN KEY (identifiantModele) REFERENCES modele(identifiant);
ALTER TABLE vol
ADD FOREIGN KEY (identifiantAeroportProvenance) REFERENCES aeroport(identifiant);
ALTER TABLE vol
ADD FOREIGN KEY (identifiantAeroportDestination) REFERENCES aeroport(identifiant);
ALTER TABLE vol
ADD FOREIGN KEY (identifiantCompagnie) REFERENCES compagnie(identifiant);
ALTER TABLE vol
ADD FOREIGN KEY (identifiantAvion) REFERENCES avion(identifiant);

USE vols;
DELETE FROM vol;
DELETE FROM compagnie;
DELETE FROM avion;
DELETE FROM modele;
DELETE FROM constructeur;
DELETE FROM aeroport;
DELETE FROM ville;
DELETE FROM pays;

INSERT INTO pays(identifiant, nom ) VALUES (1, 'France'), (2, 'Chine'), (3, 'Espagne'), (4, 'Etats-Unis'), (5, 'Italie');
INSERT INTO ville(identifiant, nom, identifiantPays ) VALUES (1, 'Paris', 1), (2, 'Nantes', 1), (3, 'Lyon', 1), (4, 'Pekin', 2), (5, 'Shanghai', 2), (6, 'Madrid', 3),  (7, 'Los Angeles', 4),  (8, 'Washington', 4);
INSERT INTO aeroport(identifiant, nom, codeAITA, identifiantVille ) VALUES (1, 'Charles de Gaulle', 'CDG', 1), (2, 'Orly', 'ORY', 1), (3, 'Nantes Atlantique', 'NTE', 2), (4, 'Lyon-Saint Exupéry', 'LYS', 3), (5, 'Pékin-Capitale', 'PKX', 4), 
(6, 'Shanghai-Pudong', 'PVG', 5), (7, 'Adolfo-Suárez', 'MAD', 6),(8, 'Los Angeles', 'LAX', 7),(9, 'Washington-Dulles', 'IAD', 7);

INSERT INTO constructeur(identifiant, nom ) VALUES (1, 'Airbus'), (2, 'Boeing'), (3, 'Douglas');

INSERT INTO modele (identifiant,identifiantConstructeur, `version`, nombreMoteurs ) VALUES (1, 3, 'DC-10', 3), (2, 2, '737', 2),  (3, 2, '747', 4),  (4, 1, 'A300', 2), (5, 1, 'A340', 4);

INSERT INTO avion(identifiant, nom, identifiantModele)  VALUES (1, 'Hugo', 1), (2, 'Flaubert', 1),(3, 'Maupassant', 5), (4, 'Proust', 3), (5, 'Montaigne', 4), (6, 'Molière', 4), (7, 'Baudelaire', 3), (8, 'La Fontaine', 3), (9, 'Rabelais', 1);

INSERT INTO compagnie(identifiant, nom ) VALUES (1, 'Air France'), (2, 'China Airlines'), (3, 'Iberia'), (4, 'American Airlines'), (5, 'Lufthansa');

INSERT INTO vol (identifiant,`code`, identifiantAeroportProvenance, identifiantAeroportDestination, identifiantCompagnie, duree,identifiantAvion) VALUES (1, 'AT754' , 1, 2, 1, 134, 1),(2, 'BG816', 2, 3, 1, 61, 2),(3, 'TE493',7, 4, 4, 220, 3),
 (4,'IZ118', 3, 5, 2, 240, 4), (5,'OP119', 5, 1, 2, 61, 5),(6,'ZX917', 1, 3, 2, 61, 2), (7,'UY587', 9, 2, 3, 145, 3), (8,'MP178', 2, 4, 1, 158, 5),(9,'NB556', 8, 7, 4, 101, 5), (10,'GF345', 4, 3, 2, 215, 6), (11,'WQ477', 1, 2, 3, 128, 3);
SELECT * From avion;

