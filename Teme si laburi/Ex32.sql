--ex 32
--0
select distinct job_id, salary
from employees;

--1
select ex.job_id ex , cur.job_id curent, nvl(ex.job_id,cur.job_id) vedem
from job_history ex right join employees cur on (ex.employee_id=cur.employee_id);

--2
select e.job_id,e.salary,e.last_name, avg(med.salary)
from employees e join employees med on (med.job_id=e.job_id)
group by e.job_id,e.salary,e.last_name;

--3
select ex.job_id,cur.salary,cur.last_name, avg(nvl(cur.salary,0)) vedem
from job_history ex right join employees cur on (ex.employee_id=cur.employee_id)
group by ex.job_id,cur.salary,cur.last_name;

--3'
select 
from job_history ex right join employees curent on (ex.employee_id = curent.employee_id and nvl(ex.end_date,0) = min(ex.end_date))

  
