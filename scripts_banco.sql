DROP DATABASE PontoDb;
CREATE Database PontoDb;
USE PontoDb;

CREATE TABLE BancoHoras (
	ID INT NOT NULL auto_increment,
    IDFuncionario INT NOT NULL,
    Dia DATETIME DEFAULT CURRENT_TIMESTAMP,
    Inicio TIME NOT NULL,
    Fim TIME NOT NULL,
    CargaDia DOUBLE,
    
    PRIMARY KEY(ID)
);
SELECT Count(IDFuncionario) FROM BancoHoras;
DELETE FROM BancoHoras
where id = 10;
INSERT INTO BancoHoras(IDFuncionario, dia, Inicio, Fim)
			    Values(1, Cast('2022-06-19' as datetime), Cast('08:00' as time), Cast('16:00' as time));
SELECT * FROM Funcionarios WHERE ID = 1;
SELECT SegundaIni, SegundaFim, TercaIni, TercaFim, QuartaIni, QuartaFim, QuintaIni, QuintaFim, SextaIni, SextaFim FROM Horarios WHERE ID = 2;
#08:00:00	16:00:00	08:00:00	16:00:00	08:00:00	16:00:00	08:00:00	16:00:00	08:00:00	16:00:00
CREATE TABLE Logins (
	ID INT NOT NULL auto_increment,
    Login VARCHAR(255) NOT NULL UNIQUE,
    Senha VARCHAR(255) NOT NULL,
    
    PRIMARY KEY(ID)
);
INSERT INTO Logins(Login, Senha)
VALUES("mklein","1234"),
	  ("mKleinGestor", "1234"),
      ("mkleinEstagio", "1234");
SELECT * FROM Logins
WHERE Login = 'mklein' AND Senha = '1234';

SELECT * FROM Funcionarios
Where IDLogin = 3;

UPDATE Funcionarios
Set IDLogin = 1
Where ID = 1;

CREATE TABLE Escalas (
	ID INT NOT NULL auto_increment,
    Segunda boolean NOT NULL,
    Terca boolean NOT NULL,
    Quarta boolean NOT NULL,
    Quinta boolean NOT NULL,
    Sexta boolean NOT NULL,
    
    PRIMARY KEY (ID)
);
INSERT INTO Escalas( Segunda, Terca, Quarta, Quinta, Sexta)
VALUES( true, true, true, true, true),
	  ( true, false, false, false, true);
select * from Escalas;

CREATE TABLE Horarios (
	ID INT NOT NULL auto_increment,
    SegundaIni TIME NOT NULL,
    SegundaFim TIME NOT NULL,
    TercaIni TIME NOT NULL,
	TercaFim TIME NOT NULL,
    QuartaIni TIME NOT NULL,
    QuartaFim TIME NOT NULL,
    QuintaIni TIME NOT NULL,
    QuintaFim TIME NOT NULL,
    SextaIni TIME NOT NULL,
    SextaFim TIME NOT NULL,
    
    PRIMARY KEY (ID)
);
SELECT * FROM Horarios;
INSERT INTO Horarios ( SegundaIni, SegundaFim, TercaIni, TercaFim, QuartaIni, QuartaFim, QuintaIni, QuintaFim, SextaIni, SextaFim)
VALUES( CAST("08:00:00" AS TIME), CAST("15:00:00" AS TIME), CAST("08:00:00" AS TIME), CAST("15:00:00" AS TIME), CAST("08:00:00" AS TIME), CAST("15:00:00" AS TIME), CAST("08:00:00" AS TIME), CAST("15:00:00" AS TIME), CAST("08:00:00" AS TIME), CAST("15:00:00" AS TIME));

CREATE TABLE Setores (
	ID INT NOT NULL auto_increment,
    Nome VARCHAR(40) UNIQUE,
    
    PRIMARY KEY(ID)
);
INSERT INTO Setores(nome)
VALUES('RH'),
	  ('Produtos');
SELECT * FROM Setores;


CREATE TABLE Funcao (
	ID INT NOT NULL auto_increment,
    Nome VARCHAR(40) UNIQUE,
    Gerencia boolean,
    
    PRIMARY KEY(ID)
);
INSERT INTO Funcao(Nome, Gerencia)
VALUES('Gestor', true),
	  ('Estagiário', false),
      ('Funcionario', false);
SELECT * FROM Funcao;


CREATE TABLE Funcionarios (
	ID INT NOT NULL auto_increment,
    NomeCompleto VARCHAR(255) NOT NULL,
    CPF VARCHAR(40) NOT NULL UNIQUE,
    RG VARCHAR(40) UNIQUE,
    PIS VARCHAR(40) UNIQUE,
    Pais VARCHAR(40),
    UF VARCHAR(5),
    Cidade VARCHAR(60),
    Endereco VARCHAR(255),
    Email VARCHAR(255) NOT NULL UNIQUE,
    EmailALT VARCHAR(255) UNIQUE,
    Telefone VARCHAR(25) UNIQUE,    
    CH INT NOT NULL,
    IDSetor INT NOT NULL,
    IDFuncao INT NOT NULL,
    IDEscala INT NOT NULL,
    IDHorario INT NOT NULL,
    IDLogin INT NOT NULL,
    Ativo boolean NOT NULL,
    
    PRIMARY KEY(ID)
);

SELECT NomeCompleto, CPF, RG, PIS, Pais, UF, Cidade, Endereco, Email, Telefone, CH, IDSetor, IDFuncao, IDEscala, IDHorario, IDLogin, Ativo FROM Funcionarios Where IDLogin = 1
SELECT CH, IDHorario FROM Funcionarios WHERE ID = 1
Insert INTO Funcionarios(NomeCompleto, CPF, RG, PIS, Pais, UF, Cidade, Endereco, Email, Telefone, CH, IDSetor, IDFuncao, IDEscala, IDHorario, IDLogin, Ativo)
VALUES("Marcelo Klein Gestor", "222.222.222-22", "2222222222", "22222222222", "Brasil", "RS", "Porto Alegre", "Av. Endereco, Bairro, 1010", "klein.marceloGestor@gmail.com", "51 92222-2222", 40, 2, 1, 4, 1, 2, 1);
SELECT * FROM Funcionarios;
-- FKS

ALTER TABLE Funcionariosfuncionarios
ADD FOREIGN KEY(IDHorario) REFERENCES Horarios(ID),
ADD FOREIGN KEY(IDSetor) REFERENCES Setores(ID),
ADD FOREIGN KEY(IDLogin) REFERENCES Logins(ID),
ADD FOREIGN KEY(IDFuncao) REFERENCES Funcao(ID),
ADD FOREIGN KEY(IDEscala) REFERENCES Escalas(ID);

ALTER TABLE Escalas
ADD FOREIGN KEY (IDFuncionario) REFERENCES Funcionarios(ID);

ALTER TABLE Horarios
ADD FOREIGN KEY (IDFuncionario) REFERENCES Funcionarios(ID);

ALTER TABLE BancoHoras
ADD FOREIGN KEY(IDFuncionario) REFERENCES Funcionarios(ID);
