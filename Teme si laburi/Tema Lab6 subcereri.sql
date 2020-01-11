select emp.last_name, emp.hire_date
from employees emp
where emp.hire_date > 
  (select hire_date
  from employees 
  where lower(last_name) = 'gates');
  
select emp.last_name, emp.salary
from employees emp
where lower(last_name) != 'gates' and emp.department_id =
  (select department_id
  from employees
  where lower(last_name) = 'gates');
  
select last_name, salary
from employees
where manager_id in
  (select employee_id
  from employees
  where manager_id is null);

desc employees;

select last_name, department_id, salary
from employees
where salary in 
  (select salary
     from   employees
  where commission_pct <> 0)
and department_id in
  (select department_id 
  from employees
  where commission_pct <>0);

select emp.employee_id, emp.last_name, emp.salary, emp.department_id

from employees emp
where emp.salary > 
  (select min_salary/2 + max_salary/2
  from jobs
  where emp.job_id = job_id)
and emp.department_id in
  (select department_id
  from employees
  where lower(last_name) like '%t%');
