script to create login and user is excluded from this repo.
create a file called create-login.sql (this file is ignored by git ignore in this repo)
add the following to that file 

--IMPORTANT create login in MASTER 
create login [loginname] with password = '[]'

--IMPORTANTswitch to HearthyHearthDB

drop user if exists appadminrecipe_user
create user [username] from login [loginname]