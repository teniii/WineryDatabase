--ex6
select last_name, salary
from employees
where salary > all
  (select avg(salary)
  from employees 
  group by department_id);
  
  select last_name, salary
from employees
where salary > all
  (select max(avg(salary))
  from employees 
  group by department_id);
  
--7
select last_name, salary, department_id 
from employees e
where salary = (select min(salary)
                from employees
                where e.department_id = department_id
                group by department_id);
                
select last_name, salary, department_id 
from employees
where salary in (select min(salary)
                from employees
                group by department_id);
                
select last_name, salary, department_id 
from employees
where salary in (select min(salary)
                from employees
                group by department_id);