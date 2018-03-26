==============================================================================================================
SA46 Team 05B ESNET ReadMe.txt
==============================================================================================================


Contents
======================================
1. Software Specification
2. Features of Team05B Project
3. Potential Problems/bugs 
======================================




Software Specification
------------------------

For the Program to run smoothly, the following Windows Programs are needed:

Visual Studio 2017
SQL Management Studio

Please Download the Team05BESNETProject compressed folders and unzip the files
For the Program to run smoothly, the following files and folders from the Team05BESNETProject folder are needed:

/packages
/SA46Team05BESNETProject
SA46Team05BESNETProject.sln
SA46Team05B ESNTET Project.bak



----------------------------
Features of Team05B Project
----------------------------

Assumptions:
----------------

1. There are four activities which members of the Sports Facility can participate in:
	-Table Tennis
	-Tennis
	-Badminton
	-Basketball
2. There are four courts available for booking per activity
3. Each court has a unique identifier FacilityID that represents the activity and the court number
	E.g. TT-1 represents Table Tennis Court 1
4. There are 20 members in the Sports Facility in the current state
x. Staff can only book facilities for the next day


Database:
----------
1. The database of the Sports Facility is built using RDBMS MSSQL
2. The database consists of four tables of:
	- Members
	- Transaction
	- Availability
