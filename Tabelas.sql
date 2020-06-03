CREATE TABLE Items(
id INTEGER PRIMARY KEY AUTOINCREMENT,
id_jog INTEGER NOT NULL,
name VARCHAR (255) NOT NULL,
quantidade INTEGER NULL,
tipo INTEGER NOT NULL,
FOREIGN KEY (id_jog) REFERENCES Players(id_jog),
FOREIGN KEY (tipo) REFERENCES PlayerItem(id)
);

CREATE TABLE PlayerItem(
id INTEGER PRIMARY KEY AUTOINCREMENT,
item_type VARCHAR(30) NOT NULL
);

CREATE TABLE Players(
id_jog INTEGER PRIMARY KEY AUTOINCREMENT,
name_jog VARCHAR(255) NOT NULL
);

INSERT INTO Players (name_jog) VALUES('player01');
INSERT INTO PlayerItem (item_type) values('straight');

INSERT INTO Items (name,quantidade, tipo,id_jog) VALUES ('Sword',2,1,1);

SELECT * FROM Items WHERE id_jog = 1;

