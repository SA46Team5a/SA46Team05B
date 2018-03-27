==============================================================================================================
SA46 Team 05B ESNET ReadMe.txt
==============================================================================================================


Contents
======================================
1. Software Specification
2. Features of Team05B Project
3. Potential Problems/bugs 
======================================



------------------------
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
x. Staff can only book facilities for the next day, one hour at a time.
6. The operating hours of the Sports Centre is 09:00 - 17:00


Database:
----------
1. The database of the Sports Facility is built using RDBMS MSSQL
2. The database consists of four tables:
	- Members (To store the members' information such as Name, NRIC/FIN, Phone etc.)
	- Transactions (To record the transaction details of each booking: Date, timeslot , FacilityID etc.)
	- Availabilities (To reflect the availability of each facility at each time slot)
	- Facilities (To record the FacilityID, type of activity and the price of booking of each facility)


System:
----------
The System will consist of 9 functions:
	- MainWindow Form
	- Booking Form
	- Availability Query Form
	- Booking Cancellation Form
	- Facilitiy Maintenance Form
	- Member Maintenance Form
	- Generate Member List Crystal Report
	- Generate Receipts Crystal Report
	- Generate Total Sales Crystal Report


-------------
|MainWindow:|
--------------
1. The MainWindow Form allows the staff to open up the other forms by clicking the buttons on the left
   sidebar.
2. The MainWindow Form acts as a container for the other forms to be opened (Multiple Document Interface).
3. The default form is Booking Form, which will be opened once the MainWindow is loaded.
4. The user can toggle between the different forms when the buttons are clicked
5. The user can hit the close button of each form without affecting the other forms
6. The user can also use Hotkeys/ Keyboard shortcuts to access each function, by hitting "Ctrl" + Underlined
   character for each button
   (E.g. Hitting "Ctrl + f" for Facility Maintenance (Underlined F) opens up the Facility Maintenance form
7. StatusStrip



-------------
|BookingForm:|
--------------
1. The Booking Form allows the user to book the facility for a particular timeslot the next day
2. The user can key in the exact name of the Member (case-sensitive) to automatically populate
   the member's NRIC/FIN
3. The user can also hit the "..." button to open up a MemberQuery form which will show the list
   of all 20 members and their NRIC/FIN on a datagridview
4. Upon selecting a particular member and clicking the "Select Member" button, the Member Name
   and NRIC will be populated in the Booking Form
5. The user can then choose the Activity (e.g Tennis) in the ComboBox and all the related FacilityID
   will be populated in the FacilityID ComboBox.
6. After selecting the FacilityID, the user can choose the timeslot in the ComboBox
7. The "Clear Form" button will clear out all Textboxes and ComboBoxes
8. The "Edit Booking" Button will bring the User to Cancel Booking Form.
9. The "Book" button will initiate a confirmation Message with the booking details, and confirm the
   booking once the user hits "Yes"
10.If any fields are incomplete/ incorrect, the "Book" Button will prompt the user to check his entries
   in the Booking Form


------------------
|AvailabiltyQuery:|
------------------
1. The Availabilty Query Form allows the user to search for the available slots for the next day.
2. The user can choose to search by Activity, or search by Time slot, or search by both
   criteria using the ComboBox
3. Upon hitting the "Search" button, the dataGridView will show a table of FacilityID VS Slotnumber
   based on the user's search criteria
4. The cell value of "1" means the facility is available, while value of "0" indicates it is 
   unavailable (E.g At column Slot1, row TT-1, the value of "1" indicates the Table Tennis court 1 is
   available at Slot1 - 09:00-10:00)
5. The "Display" button will show the availabilities of every facility at every timeslot for the next
   day
6. The user can also update the availability using the dataGridView. To enable editing of a cell,
   double-click the particular cell to change its value
7. Once the user completes the change, the "Update" button will reflect the availabilities in the 
   database
 


---------------------
|BookingCancellation:|
---------------------
1. The Booking Cancellation Form allows the user to search the members' bookings for the next day
   and cancel the bookings due to unforseen circumstances
2. The user can key in the Member's NRIC/FIN or use the "..." button to initiate the MemberQuery
3. The memberQuery works in the same way as the BookingForm, where the NRIC/FIN will be populated
   in the TextBox in CancelBooking Form once the Member is selected
4. The user can show all of a particular member's bookings by hitting the "Search Member's Booking"
   button if the NRIC is valid
5. The system will prompt the user to key in the correct NRIC/FIN if it is invalid
6. If the user wants to cancel a particular booking, he/she can hit the "Click to toggle Cancel"
   button and hit "Cancel Button.
7. Multiple cancel options is viable



---------------------
|FacilityMaintenance:|
---------------------
1. The Facility Maintenance Form allows the user to change the FacilityID and Price of the Facility
   using the dataGridView
2. Hitting the "Display Facilities Table" will display the FacilityID, Activity and Price
3. The user can edit the cell values by clicking the particular cell
4. The "Update" button will record all changes to the Facilities Table



-------------------
|MemberMaintenance:|
-------------------
1. The Member Maintenance Form allows the user to access Create, Read, Update, Delete functions on the
   Members Table, which contains the members' information
2. The same set of Textboxes for the members' information will be used across all the CRUD functions
3. The "<" button will bring the user to the previous entry of member information, while the ">" button
   brings the user to the next entry.
4. Hitting "<" when the fields are empty will populate the first member's information, while ">" brings
   the user to the second entry
5. The "<" and ">" will not work once it reaches the first/ last entry respectively
6. The "<<" button will bring the user to the first entry of member information, while the ">>" button
   brings the user to the last entry.
7. The "Update" button will update the changed member information to the Members Table. It only work 
   if all the fields are populated.
8. The "Insert" button will insert a new member information to the Members Table, only if all the details
   are filled.
9. The "Delete" button will delete a member information in the Members Table, only if it is a valid member
10.The user can also search for a member using his/her NRIC/FIN. If the NRIC/FIN is valid, it will populate
   the textboxes with the member's information holding the NRIC/FIN. There will be an error message box if
   the NRIC/FIN is invalid


--------------
|CRMemberList:|
--------------
1. Hitting the "CRMemberList" button will display a list of members with their details using Crystal report


-----------
|CRReceipt:|
-----------
1. Hitting the "CRReceipt" button will display all the receipts in the Transactions records


--------------
|CRTotalSales:|
--------------
1. Hitting the "CRTotalSales" button will display the total historical sales for each timeslot and facility



--------------------------
Potential Problems or Bugs
--------------------------

1. In the Query Form, there may be instances where the the columns are not in order (i.e. Slot1 is not the first
   column)
2. The DataGridview are designed to be editable, therefore some of the dataGridview can be be edited
3. Enum/Dictionary can be used for storing the Slot names variables instead of using string to store each name. This
   will reduce hard coding and introduce loops when writing methods