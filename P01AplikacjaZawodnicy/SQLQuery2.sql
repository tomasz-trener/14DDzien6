go
drop procedure Szukaj
go
create proc Szukaj(@dane varchar(255), @ile int, @strona int)
as
begin
	select id_zawodnika, id_trenera, imie, nazwisko, kraj, data_ur, wzrost, waga from zawodnicy
	where 
    imie like '%'+@dane+'%' or 
	nazwisko like '%'+@dane+'%' or
	kraj like '%'+@dane+'%' or
	format(data_ur,'ddMMyyyy') like '%'+@dane+'%' or
	format(waga,'0') like '%'+@dane+'%' or
	format(wzrost,'0') like '%'+@dane+'%'
	order by id_zawodnika
	offset (@strona-1)*@ile rows 
	fetch next @ile rows only

	select convert(int, ceiling(CONVERT(decimal, count(*))/@ile)) ile from zawodnicy
	where 
    imie like '%'+@dane+'%' or 
	nazwisko like '%'+@dane+'%' or
	kraj like '%'+@dane+'%' or
	format(data_ur,'ddMMyyyy') like '%'+@dane+'%' or
	format(waga,'0') like '%'+@dane+'%' or
	format(wzrost,'0') like '%'+@dane+'%'
end

exec Szukaj '', 3,1

select format(data_ur,'ddMMyyyy') , format(wzrost,'0'), wzrost
from zawodnicy

ile =5
strona

select * from zawodnicy
