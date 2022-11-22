CREATE DATABASE db_moneygement
    WITH
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Indonesian_Indonesia.1252'
    LC_CTYPE = 'Indonesian_Indonesia.1252'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1
    IS_TEMPLATE = False;
	
CREATE TABLE IF NOT EXISTS public.users
(
    user_id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    username character varying(20) COLLATE pg_catalog."default" NOT NULL,
    password character varying COLLATE pg_catalog."default" NOT NULL,
    name character varying(20) COLLATE pg_catalog."default" NOT NULL,
    email character varying COLLATE pg_catalog."default" NOT NULL,
    phone character varying(20) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT users_pkey PRIMARY KEY (user_id)
);

CREATE TABLE IF NOT EXISTS public.income
(
    income_id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    income_name character varying(20) COLLATE pg_catalog."default" NOT NULL,
    income_amount integer NOT NULL,
    income_category character varying(20) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT income_pkey PRIMARY KEY (income_id)
);

CREATE TABLE IF NOT EXISTS public.income_transaction
(
    inctransaction_id integer NOT NULL,
    date date NOT NULL,
    user_id integer,
    income_id integer,
    CONSTRAINT income_transaction_pkey PRIMARY KEY (inctransaction_id),
    CONSTRAINT fk_income FOREIGN KEY (income_id)
        REFERENCES public.income (income_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_user FOREIGN KEY (user_id)
        REFERENCES public.users (user_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);

CREATE TABLE IF NOT EXISTS public.expense
(
    expense_id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    expense_name character varying(20) COLLATE pg_catalog."default" NOT NULL,
    expense_amount integer NOT NULL,
    expense_category character varying(20) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT expense_pkey PRIMARY KEY (expense_id)
);

CREATE TABLE IF NOT EXISTS public.expense_transaction
(
    exptransaction_id integer NOT NULL,
    date date NOT NULL,
    user_id integer,
    expense_id integer,
    CONSTRAINT expense_transaction_pkey PRIMARY KEY (exptransaction_id),
    CONSTRAINT fk_expense FOREIGN KEY (expense_id)
        REFERENCES public.expense (expense_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_user FOREIGN KEY (user_id)
        REFERENCES public.users (user_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);

CREATE OR REPLACE FUNCTION public.st_insert(
	_username character varying,
	_password character varying,
	_name character varying,
	_email character varying,
	_phone character varying)
    RETURNS integer
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
AS $BODY$
begin
	insert into public.users
	(
		username, 
		password, 
		name, 
		email, 
		phone
	)
	values
	(
		_username, 
		_password, 
		_name, 
		_email, 
		_phone
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end
$BODY$;

CREATE OR REPLACE FUNCTION public.income_select(
	)
    RETURNS TABLE(_income_name character varying, _income_amount integer, _income_category character varying) 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$
begin
	return query
	select income_name, income_amount, income_category from income;
end
$BODY$;

CREATE OR REPLACE FUNCTION public.income_insert(
	_income_name character varying,
	_income_amount integer,
	_income_category character varying)
    RETURNS integer
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
AS $BODY$
begin
	insert into public.income
	(
		income_name, 
		income_amount, 
		income_category
	)
	values
	(
		_income_name, 
		_income_amount, 
		_income_category
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end
$BODY$;

CREATE OR REPLACE FUNCTION public.expense_select(
	)
    RETURNS TABLE(_expense_name character varying, _expense_amount integer, _expense_category character varying) 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$
begin
	return query
	select expense_name, expense_amount, expense_category from expense;
end
$BODY$;

CREATE OR REPLACE FUNCTION public.expense_insert(
	_expense_name character varying,
	_expense_amount integer,
	_expense_category character varying)
    RETURNS integer
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
AS $BODY$
begin
	insert into public.expense
	(
		expense_name, 
		expense_amount, 
		expense_category
	)
	values
	(
		_expense_name, 
		_expense_amount, 
		_expense_category
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end
$BODY$;

CREATE OR REPLACE FUNCTION public.show_all(
	)
    RETURNS TABLE(_income_id integer, _income_name character varying, _income_amount integer, _income_category character varying, _expense_id integer, _expense_name character varying, _expense_amount integer, _expense_category character varying) 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$
begin
	return query
	select * from income full outer join expense on income.income_id = expense.expense_id;
end
$BODY$;