--ex1
select coleg.last_name,to_char(coleg.hire_date,'MON YYYY')
from  employees gates join  employees coleg 
on ((gates.department_id=coleg.department_id and lower(gates.last_name)='gates')and
coleg.last_name like '%a%' and 
lower(coleg.last_name)<>lower('gates'));

--ex2
select coleg.employee_id, coleg.last_name,department_name, coleg.department_id
from employees t join employees coleg
on (t.last_name like '%t%' and t.department_id=coleg.department_id) 
left join departments on (t.department_id=departments.department_id)
order by coleg.last_name asc;
