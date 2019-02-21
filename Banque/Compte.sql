BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS `Compte` (
	`id`	INTEGER NOT NULL UNIQUE,
	`nom`	TEXT NOT NULL,
	`prenom`	TEXT NOT NULL,
	`dateNaissance`	TEXT NOT NULL,
	`codeCompte`	TEXT NOT NULL UNIQUE,
	`dateCreation`	TEXT NOT NULL,
	`typeCompte`	TEXT NOT NULL,
	`solde`	REAL NOT NULL,
	`plafond`	REAL,
	PRIMARY KEY(`codeCompte`)
);
INSERT INTO `Compte` (id,nom,prenom,dateNaissance,codeCompte,dateCreation,typeCompte,solde,plafond) VALUES (1,'CAMENEN','Daniel','01/01/1901','0001-CD-Comptecourant','22/05/1999','Compte courant',1000.0,'');
INSERT INTO `Compte` (id,nom,prenom,dateNaissance,codeCompte,dateCreation,typeCompte,solde,plafond) VALUES (2,'BAH','Ibrahim','01/01/1901','0002-BI-Comptecourant','22/05/1999','Compte courant',1523.0,'');
INSERT INTO `Compte` (id,nom,prenom,dateNaissance,codeCompte,dateCreation,typeCompte,solde,plafond) VALUES (3,'BONNETAIN','Maxime','01/01/1901','0003-CD-Comptecourant','22/05/1999','Compte courant',12000.0,'');
INSERT INTO `Compte` (id,nom,prenom,dateNaissance,codeCompte,dateCreation,typeCompte,solde,plafond) VALUES (4,'BOUDOT','Serge','01/01/1901','0004-BS-Comptejeune','22/05/1999','Compte jeune',125000.0,1200.0);
INSERT INTO `Compte` (id,nom,prenom,dateNaissance,codeCompte,dateCreation,typeCompte,solde,plafond) VALUES (5,'CELLIER','Florent','01/01/1901','0005-CF-Comptejeune','22/05/1999','Compte jeune',12.5,1200.0);
INSERT INTO `Compte` (id,nom,prenom,dateNaissance,codeCompte,dateCreation,typeCompte,solde,plafond) VALUES (6,'DAUVERGNE','Maxime','01/01/1901','0006-DM-Comptecourant','22/05/1999','Compte courant',2961.0,'');
INSERT INTO `Compte` (id,nom,prenom,dateNaissance,codeCompte,dateCreation,typeCompte,solde,plafond) VALUES (7,'DE ROQUEMAUREL','Ambroise','01/01/1901','0007-DA-Comptecourant','22/05/1999','Compte courant',-527.62,'');
INSERT INTO `Compte` (id,nom,prenom,dateNaissance,codeCompte,dateCreation,typeCompte,solde,plafond) VALUES (8,'GORSE','Thierry','01/01/1901','0008-GT-Pland''épargnelogement','22/05/1999','Plan d''épargne logement',2798.25,1200.0);
INSERT INTO `Compte` (id,nom,prenom,dateNaissance,codeCompte,dateCreation,typeCompte,solde,plafond) VALUES (9,'LEMAISTRE','François','01/01/1901','0009-LF-Comptecourant','22/05/1999','Compte courant',652.3,'');
INSERT INTO `Compte` (id,nom,prenom,dateNaissance,codeCompte,dateCreation,typeCompte,solde,plafond) VALUES (10,'POUPARD','Benjamin','01/01/1901','0010-PB-Comptejeune','22/05/1999','Compte jeune',99.8,1200.0);
COMMIT;
