CRUD APPLICATION USING VISUAL STUDIO AND MYSQL DATABASE
Faciliates in understanding and demonstrating about the basic concepts of CREATE,READ,UPDATE AND DELETE.
 
 
BUILT WITH
Programming Language: C#(.Net Framework)
 
Database: Microsoft SQL Server
 
IDE: Visual Studio / VS Code
 
FEATURES (BUTTONS)
Insert: Add new user data to the database.
 
Delete: Remove existing user data based on userid.
 
Update: Modify details of a selected user.
 
Search: Search for the existing data from the datagridview
 
SQL QUERY
Table Design
 
CREATE TABLE [dbo].[Product_Info] ( [ProductID] INT (50), [ItemName] VARCHAR (50) , [Color] VARCHAR (50), [Date] datetime , CONSTRAINT [PK_Product_ID] PRIMARY KEY CLUSTERED ([ProductID] ASC) );
 
Insert
 
"Insert into Product_Info values ('" + int.Parse(textBox1.Text) + "','"
 
    con.Open();
 SqlCommand command = new SqlCommand("insert into Product_Info values ('" + int.Parse(textBox2.Text) + "','" + textBox3.Text + "','" + comboBox1.Text + "', getdate())", con);
 command.ExecuteNonQuery();
 con.Close();
 MessageBox.Show("Successfully Inserted.");
 BindData();
 
Update
 
update Product_Info set MemberName='" + textBox2.Text
 
   con.Open();
 SqlCommand command = new SqlCommand("update Product_Info set ItemName= '" + textBox3.Text + "', Color ='" + comboBox1.Text + "' where ProductID = '" + int.Parse(textBox2.Text) + "'", con);
 command.ExecuteNonQuery();
 con.Close();
 MessageBox.Show("Successfully Update.");
 BindData();
 
Delete
 
 con.Open();
 SqlCommand command = new SqlCommand("Delete Product_Info where ProductID= '" + int.Parse(textBox2.Text) + "'", con);
 command.ExecuteNonQuery();
 con.Close();
 MessageBox.Show("Successfully Deleted.");
 BindData();
 
Search
 
 SqlCommand command = new SqlCommand("select * from Product_Info where ProductID= '" + int.Parse(textBox2.Text) + "'", con);
 SqlDataAdapter sd = new SqlDataAdapter(command);
 DataTable dt = new DataTable();
 sd.Fill(dt);
 dataGridView1.DataSource = dt;
TECHNOLOGY
Programming Language: C#
 
Database: SQL Server
 
Framework: Windows Forms
 
UI Components:
 
Text Box for entering data.
Button for response.
Data Grid View for displaying and managing data
🛠 Skills
C#
 
NET Framework
 
SQL Server
 
Windows Forms Development
has context menu
