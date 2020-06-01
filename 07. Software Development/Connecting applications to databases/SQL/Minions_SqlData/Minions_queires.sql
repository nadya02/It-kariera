use MinionsDB;
--Problem 2--

select v.Name, Count(MinionId) as c
from Villians as v
join MinionsVillians
on id = VillianId
group by v.Name
having Count(MinionId) >= 3
order by c desc;

select v.Name, 
(select count(*) from MinionsVillians where VillianId = v.id) as Minion_Count
from villians as v
where (select count(*) from MinionsVillians where VillianId = v.id) > 3
order by Minion_Count desc;

--Problem 3--

select id from villians where id = 6;  

select Name from villians where id = 2;

select m.Name, m.Age
from Minions as m
join MinionsVillians as mv
on mv.MinionId = m.id
where mv.VillianId = 6
order by m.Name asc;



--Problem 4--

select * from Towns where CountryCode = '1';
select Name from countries where Name = 'Bulgaria';