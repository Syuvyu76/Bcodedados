describe tcc
alter table tcc
drop column  obs_tcc;
alter table tcc
add column observacao tinytext not null;
select * from alunos;