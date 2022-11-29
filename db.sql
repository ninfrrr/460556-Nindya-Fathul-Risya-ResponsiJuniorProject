create table departemen
(
	id_dep int primary key,
	nama_dep varchar(30)
);
drop table karyawan;

create table karyawan
(
	id_karyawan character varying(6) primary key,
	nama varchar(30)
);

select * from karyawan cross join departemen;

---insert functuin---
create function hr_insert
(
	_nama_dep int,
	_nama varchar
)
returns int as 
'
BEGIN
	insert into public.karyawan
	( nama_dep, nama )
	values ( _nama_dep, _nama );
	if found then
			return 1;
	else
		return 0;
	end if;
end
'
language plpgsql;

---select function---
create function hr_select()
returns table
(
	_id_dep int,
	_nama_dep varchar,
	_id_karyawan int,
	_nama varchar
)
language plpgsql as
'
begin
	return query
	select id_dep, nama_dep, id_karyawan, nama from karyawan;
end
'
drop FUNCTION hr_select;

---update function---
create or replace function hr_update
(
	_id_dep int,
	_nama_dep varchar,
	_id_karyawan int,
	_nama varchar
)
returns int as 
'
begin
	update karyawan set
		nama_dep = _nama_dep,
		nama = _nama,
		id_dep = _id_dep
	where id_karyawan = _id_karyawan;
	if found then 
			return 1;
	else
		return 0;
	end if;
end
'
language plpgsql;

insert into departemen (id_dep, nama_dep) values (01, 'HR');

--- delete function---
create or replace function hr_delete(_id character varying)
returns int as 
'
begin
	delete from public.karyawan
	where id_karyawan = _id_karyawan;
	if found then 
		return 1;
	else
		return 0;
	end if;
end
'
language plpgsql;