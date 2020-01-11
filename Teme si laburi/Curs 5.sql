select e.employee_id,e.manager_id
from employees e join employees e114 on (e.manager_id=e114.manager_id)
where e114.employee_id=114;


select *
from employees
where manager_id=(
select manager_id
from employees
where employee_id=114) and employee_id!=114 ;

select *
from employees
where salary <=all(
  select salary from employees);
  
select ang.last_name, ang.department_id, ang.salary
from employees ang join employees com on
(ang.department_id||'@'||ang.salary=com.department_id||'@'||com.salary)
where com.commission_pct is not null and ang.employee_id<>com.employee_id;


select ang.last_name, ang.department_id, ang.salary
from employees ang
where (ang.department_id,ang.salary) in (select com.department_id,com.salary
from employees com
where com.commission_pct is not null and ang.employee_id<>com.employee_id);
select *
from employees natural join departments;

select *
from employees natural join departments;


select *
from employees e join departments d on (e.department_id=d.department_id and e.manager_id=d.manager_id);









