<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="LoginForm.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../Scripts/Style.css"/>
        
    <script src="https://code.jquery.com/jquery-3.7.1.js" integrity="sha256-eKhayi8LEQwp4NKxN+CfCh+3qOVUtJn3QNZ0TciWLP4=" crossorigin="anonymous"></script>
    <script src="https://code.jquery.com/jquery-3.7.1.slim.js" integrity="sha256-UgvvN8vBkgO0luPSUl2s8TIlOSYRoGFAX4jlCIm9Adc=" crossorigin="anonymous"></script>
    <script src="https://code.jquery.com/jquery-3.7.1.min.js" integrity="sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo=" crossorigin="anonymous"></script>
    <script src="https://code.jquery.com/ui/1.13.2/jquery-ui.min.js" integrity="sha256-lSjKY0/srUM9BE3dPm+c4fBo1dky2v27Gdjm2uoZaL0=" crossorigin="anonymous"></script>
      
    <script src="../Scripts/script.js"></script>
   

</head>
<body>
    <form id="form1" runat="server" >
        <div>
            <h2>Registration Form</h2>
    
    
        <div>
            <label for="name">Name:</label>
            <input type="text" id="name" name="name" required/><br />
        
            <label for="address">Address:</label>
            <textarea id="address" name="address" required></textarea><br />
        
            <label for="gender">Gender:</label>
            <input type="radio" id="male" name="gender" value="male" required/>Male
            <input type="radio" id="female" name="gender" value="female" required/>Female<br />


            <label for="state">State:</label>
            <select id="states" name="states" required>
            <option disabled selected value="">Select State</option>
            <option value="Andhra Pradesh">Andhra Pradesh</option>
            <option value="Arunachal Pradesh">Arunachal Pradesh</option>
            <option value="Assam">Assam</option>
            <option value="Bihar">Bihar</option>
            <option value="Chhattisgarh">Chhattisgarh</option>
            <option value="Goa">Goa</option>
            <option value="Gujarat">Gujarat</option>
            <option value="Haryana">Haryana</option>
            <option value="Himachal Pradesh">Himachal Pradesh</option>
            <option value="Jharkhand">Jharkhand</option>
            <option value="Karnataka">Karnataka</option>
            <option value="Kerala">Kerala</option>
            <option value="Madhya Pradesh">Madhya Pradesh</option>
            <option value="Maharashtra">Maharashtra</option>
            <option value="Manipur">Manipur</option>
            <option value="Meghalaya">Meghalaya</option>
            <option value="Mizoram">Mizoram</option>
            <option value="Nagaland">Nagaland</option>
            <option value="Odisha">Odisha</option>
            <option value="Punjab">Punjab</option>
            <option value="Rajasthan">Rajasthan</option>
            <option value="Sikkim">Sikkim</option>
            <option value="Tamil Nadu">Tamil Nadu</option>
            <option value="Telangana">Telangana</option>
            <option value="Tripura">Tripura</option>
            <option value="Uttar Pradesh">Uttar Pradesh</option>
            <option value="Uttarakhand">Uttarakhand</option>
            <option value="West Bengal">West Bengal</option>
            <option value="Andaman and Nicobar Islands">Andaman and Nicobar Islands</option>
            <option value="Chandigarh">Chandigarh</option>
            <option value="Dadra and Nagar Haveli and Daman and Diu">Dadra and Nagar Haveli and Daman and Diu</option>
            <option value="Lakshadweep">Lakshadweep</option>
            <option value="Delhi">Delhi</option>
            <option value="Puducherry">Puducherry</option>
        </select><br />
            
            <label for="phone">Phone Number:</label>
            <input type="tel" id="phone" name="phone" maxlength="10" pattern="[0-9]{10}" title="Please enter a 10-digit phone number" required/><br />

        
            <label for="course">Select Courses:</label><br />
            
            <input type="checkbox" id="python" name="course[]" value="50"/>
            <label for="python">Python - $50</label><br />
       
            <input type="checkbox" id="c" name="course[]" value="40"/>
            <label for="c">C - $40</label><br />
        
            <input type="checkbox" id="cplusplus" name="course[]" value="60"/>
            <label for="cplusplus">C++ - $60</label><br />
        
            <input type="checkbox" id="java" name="course[]" value="55"/>
            <label for="java">Java - $55</label><br />
            
            <label for="total">Total Price:</label>
            <input type="text" id="total" name="total" readonly/><br /><br />

            <label for="email">Email:</label>
            <input type="email" id="email" name="email" required/><br /><br />

            <label for="password">Password:</label>
            <input type="password" id="password" name="password" required/><br /><br />

            <label for="confirmPassowrd">Confirm Password:</label>
            <input type="password" id="confirmPassword" name="confirmPassword" required/><br /><br />

            <div id="passwordMatchMessage"></div>



           <%-- <button type="button" id="btnsave" onclick="submit();">SAVE</button>--%>

            <button type="submit" id="submit">SAVE</button>
            <%--<asp:Button  ID="save" runat="server" Text="Save" onClientclick="submit();" />--%>
           
            <%--<asp:Button ID="updateForm" runat="server" Text="Update" onClientclick="update();return false" />--%>
            
            
           
        </div>
          <%--<div id="popupContent" style="display: none;" class="modal">
              <div class="modal-content">
                  <h2> Update Registration Form</h2>
                  <asp:Button ID="close" runat="server" Text="&times;" class="close" OnClientClick="closeModal();return false"/>
                   
                  <div>
            <label for="name">Name:</label>
            <input type="text" id="updateName" name="updateName" required/><br /><br />
        
            <label for="address">Address:</label>
            <textarea id="UpdateAddress" name="UpdateAddress" required></textarea><br /><br />
        
            <label for="state">State:</label>
            <select id="state" name="state">
                <option value="Andhra Pradesh">Andhra Pradesh</option>
                <option value="Arunachal Pradesh">Arunachal Pradesh</option>
                <option value="Assam">Assam</option>
                <option value="Bihar">Bihar</option>
                <option value="Chhattisgarh">Chhattisgarh</option>
                <option value="Goa">Goa</option>
                <option value="Gujarat">Gujarat</option>
                <option value="Haryana">Haryana</option>
                <option value="Himachal Pradesh">Himachal Pradesh</option>
                <option value="Jharkhand">Jharkhand</option>
                <option value="Karnataka">Karnataka</option>
                <option value="Kerala">Kerala</option>
                <option value="Madhya Pradesh">Madhya Pradesh</option>
                <option value="Maharashtra">Maharashtra</option>
                <option value="Manipur">Manipur</option>
                <option value="Meghalaya">Meghalaya</option>
                <option value="Mizoram">Mizoram</option>
                <option value="Nagaland">Nagaland</option>
                <option value="Odisha">Odisha</option>
                <option value="Punjab">Punjab</option>
                <option value="Rajasthan">Rajasthan</option>
                <option value="Sikkim">Sikkim</option>
                <option value="Tamil Nadu">Tamil Nadu</option>
                <option value="Telangana">Telangana</option>
                <option value="Tripura">Tripura</option>
                <option value="Uttar Pradesh">Uttar Pradesh</option>
                <option value="Uttarakhand">Uttarakhand</option>
                <option value="West Bengal">West Bengal</option>
                <option value="Andaman and Nicobar Islands">Andaman and Nicobar Islands</option>
                <option value="Chandigarh">Chandigarh</option>
                <option value="Dadra and Nagar Haveli and Daman and Diu">Dadra and Nagar Haveli and Daman and Diu</option>
                <option value="Lakshadweep">Lakshadweep</option>
                <option value="Delhi">Delhi</option>
                <option value="Puducherry">Puducherry</option>
            </select><br /><br />

            <label for="phone">Phone Number:</label>
            <input type="tel" id="UpdatePhone" name="phone" pattern="[0-9]{10}" title="Please enter a 10-digit phone number" required/><br /><br />
        
            <button type="submit" id="upadte">Save</button>&nbsp&nbsp&nbsp
            <button type="button" id="delete">Delete</button>
        </div>
                   
        </div>
              

         </div>--%>
    
             
        </div>
    </form>


</body>
</html>
