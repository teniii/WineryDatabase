--LAb 5 Facultate
--ex 6
select last_name, salary
from employees
where salary > all (select max(avg(salary))
                    from employees
                    group by department_id);
                    

--ex 7
select last_name, salary, e.department_id
from employees
where (salary,department_id) in (select min(salary)
                    from employees
                    group by department_id);
                    
select last_name, d.department_id, department_name
from employees e right join departments d 
on (e.department_id = d.department_id)
where hire_date = (select min(hire_date)
from employees 
where department_id = d.department_id)
or hire_date is null
order by 3;

--ex 9
select last_name, salary
from employees
where department_id in(
select department_id 
from employees 
where salary = (
select max(salary)
from employees
where department_id = 30));

select last_name, salary
from employees e
where exists(
select 1 
from employees 
where salary = (
select max(salary)
from employees
where department_id = 30) and department_id = e.department_id);


--ex11

with ierarhie as
(select employee_id ang, manager_id sef
from employees
connect by employee_id = prior manager_id),

nrsub as (select ang, count (*)-1 nr
from ierarhie 
group by ang)

select *
from nrsub
where nr>5;

--Lab 7
--ex1
create table emp as select * from employees;
create table dept as select * from departments;

--ex 4
ALTER TABLE emp
ADD CONSTRAINT pk_emp 
PRIMARY KEY(employee_id);

ALTER TABLE dept
ADD CONSTRAINT pk_dept_pnu 
PRIMARY KEY(department_id);

ALTER TABLE emp
ADD CONSTRAINT fk_emp_dept
FOREIGN KEY(department_id) 
REFERENCES dept(department_id);

--ex 5
INSERT INTO DEPT (department_id, department_name)
VALUES (300, 'Programare');

commit;


