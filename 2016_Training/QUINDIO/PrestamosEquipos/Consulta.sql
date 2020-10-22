alter table estudiantes add constraint uq_codest UNIQUE(codigo);

alter table dispositivos add constraint uq_codequipo UNIQUE(codigo);

SELECT * FROM ESTUDIANTES;

select * from Dispositivos;
select* from prestamos