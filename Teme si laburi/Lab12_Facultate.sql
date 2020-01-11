--LAb12
--Lab_site7
--ex 8
create table emp0 as
select * from employees
where 1 = 2;

insert into emp1
select *
from employees
where commission_pct > 0.25;

rollback;

-- ex 9
insert first
when department_id = 80 then into emp0
when salary < 5000 then into emp1
when salary between 5000 and 10000 then into emp2
when salary > 10000 then into emp3
select * from employees;

--ex 10
update emp
set salary = salary* 1.05;
rollback;

--ex11
select employee_id
from employees
where lower(last_name||first_name) = 'grantdouglas';

update dept
set manager_id = (select employee_id
from employees
where lower(last_name||first_name) = 'grantdouglas')
where department_id = 20;

update emp
set salary = salary + 1000
where employee_id =( select employee_id
from employees
where lower(last_name||first_name) = 'grantdouglas');

--ex 12
select min(salary)
from emp;

select employee_id
from employees
where salary = ( select min(salary)
from employees);

update emp a
set (salary,commission_pct) = 
        (select salary, commission_pct
        from emp
        where employee_id = a.manager_id)
where salary = (select min(salary)
from employees);

rollback;

--ex 13
update emp
set (job_id, department_id) = 
      (select job_id, department_id
      from emp 
      where employee_id = 205)
where employee_id = 114;

--ex 14
delete from departments;

delete from emp
where commission_pct is null;

rollback;

--ex 16
delete from emp
where employee_iid = 197;

--ex 17
insert into dept 
values (340, 'dep nou', null, null);

--ex 18
savepoint pizza;

--ex 19
delete from dept
where department_id is not in (select nvl(department_id, 0)
                                from emp);
                                
rollback to pizza;

commit;


--ex 22

MERGE INTO emp x
 USING employees e
 ON (x.employee_id = e.employee_id)
 WHEN MATCHED THEN
UPDATE SET
 x.first_name=e. first_name,
 x.last_name=e.last_name,
 x.email=e.email,
 x.phone_number=e.phone_number,
 x.hire_date= e.hire_date,
 x.job_id= e.job_id,
 x.salary = e.salary,
 x.commission_pct= e.commission_pct,
 x.manager_id= e.manager_id,
 x.department_id= e.department_id
WHEN NOT MATCHED THEN
 INSERT VALUES (e.employee_id, e.first_name, e.last_name, e.email,
 e.phone_number, e.hire_date, e.job_id, e.salary, e.commission_pct, e.manager_id,
 e.department_id);
