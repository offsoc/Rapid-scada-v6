-- project."view" definition

-- Drop table

-- DROP TABLE project."view";

CREATE TABLE project."view" (
	file_id int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY,
	"path" varchar NOT NULL,
	"content" varchar NULL,
	CONSTRAINT view_path_un UNIQUE (path),
	CONSTRAINT view_pkey PRIMARY KEY (file_id)
);