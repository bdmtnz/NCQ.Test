
-- Db Name Configured is Taks.db

-- Tasks definition

CREATE TABLE Tasks (
	Id INTEGER PRIMARY KEY AUTOINCREMENT,
	Description TEXT NOT NULL,
	StatusId INTEGER,
	PriorityId INTEGER,
	Notes TEXT,
	Commitment DATETIME
);

-- Terms definition

CREATE TABLE Terms (
	Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Code TEXT NOT NULL,
    Name TEXT,
    ParentId INTEGER,
    FOREIGN KEY (ParentId) REFERENCES Terms(Id)
);

-- Seeder

INSERT INTO Terms
(Code, Name, ParentId)
VALUES('STATES', 'Estados', NULL);
INSERT INTO Terms
(Code, Name, ParentId)
VALUES('STATES_PENDING', 'Pendiente', 1);
INSERT INTO Terms
(Code, Name, ParentId)
VALUES('STATES_PROCESSING', 'En Proceso', 1);
INSERT INTO Terms
(Code, Name, ParentId)
VALUES('STATES_ENDED', 'Finalizada', 1);
INSERT INTO Terms
(Code, Name, ParentId)
VALUES('PRIORITIES', 'Prioridades', NULL);
INSERT INTO Terms
(Code, Name, ParentId)
VALUES('PRIORITIES_HIGH', 'Alta', 5);
INSERT INTO Terms
(Code, Name, ParentId)
VALUES('PRIORITIES_MIDDLE', 'Media', 5);
INSERT INTO Terms
(Code, Name, ParentId)
VALUES('PRIORITIES_LOW', 'Baja', 5);