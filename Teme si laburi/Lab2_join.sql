--17
select last_name, departments.department_id, departments.department_name
from employees left join departments on (employees.department_id=departments.department_id);

--18
select distinct job_title
from employees join departments on (employees.department_id=departments.department_id and employees.department_id =30)
join jobs on (jobs.job_id = employees.job_id);

--19
select last_name, department_name, street_address
from employees left join departments 
on (employees.department_id=departments.department_id and 
nvl(employees.commission_pct,0) <> 0)
join locations on (locations.location_id=departments.location_id);

--20
select last_name, department_name
from employees left join departments 
on (employees.department_id=departments.department_id) 
where last_name like '%a%';

--21
select last_name, job_title, employees.department_id, department_name 
from employees join jobs
on (employees.job_id=jobs.job_id)
join departments on (employees.department_id=departments.department_id)
join locations on (locations.location_id=departments.location_id
and city='Oxford');

--22 n-a iesit
select employee_id, last_name, manager_id
from employees join employees where(employees.manager_id=employess.employee_id)

--24
