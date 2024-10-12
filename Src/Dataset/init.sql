CREATE TABLE File (
    id SERIAL UNIQUE,
    fileName TEXT NOT NULL,
    filePath TEXT NOT NULL,
    description TEXT,
    tags TEXT
);

COPY File
FROM '/docker-entrypoint-initdb.d/nessie_guitar.png'
DELIMITER ','
CSV HEADER;