# Usage Guide 📖  

## Installation Requirements ⚙️  

### 1️⃣ Prerequisites 🔧  
Ensure the following software is installed before running the project:  
- **Visual Studio 2019** (or a higher version) with **.NET Desktop Development** workload enabled.  
- **SQL Server 2019** (or a higher version) installed and configured.  
- **SQL Server Management Studio (SSMS)** for managing the database and running SQL queries.  

### 2️⃣ Database Setup 🛠️  
Run the provided SQL scripts to set up the database:  
- **Setup Database** → `setup_database_of_app.sql`  
- **Delete Database** → `delete_database_of_app.sql` (for deleteing the database) 
 
Make sure your SQL Server connection string matches this format: @"Data Source=.\SQLEXPRESS;Initial Catalog=BikeStores_44330760199;Integrated Security=True"
> 🔄 You can modify the connection string if your SQL Server instance name or security is different.  

### 3️⃣ Prepare Debug Folder 🗂️  

Ensure the following files and folders from the **`content_of_debug`** folder are present in the application's execution location (usually **`bin\Debug`**):  
- A folder named **`imageofuser`** → This folder stores user profile images.  
- An image file named **`man.png`** → This image is used as the default user profile picture.  

Both the folder and the image can be found inside the **`content_of_debug`** directory. Make sure to copy them to the same directory where the application's executable file is located to ensure proper display of images.  

Now, you're all set to run the **Sales & Inventory Management System**! ✅ 


 

