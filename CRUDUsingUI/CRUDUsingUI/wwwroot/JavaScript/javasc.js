//function fncEdit(id) {
//    var index = getIndexOf(id);
//    if (index > -1) {
//        $('#txtEditName').val(data[index].name);
//        $('#txtEditProfession').val(data[index].profession);
//        $('#txtEditAge').val(data[index].age);
//        $('#editform').attr('onSubmit', 'fncUpdate(\'' + index + '\')');
//    }
//}
function fncEdit(id) {
    // Assuming you have a function to fetch employee details by ID
    // You need to replace `fetchEmployeeDetailsById` with your actual function
    fetchEmployeeDetailsById(id)
        .then(employee => {
            // Assuming you have form fields with IDs: name, profession, age
            document.getElementById('name').value = employee.Name;
            document.getElementById('profession').value = employee.Profession;
            document.getElementById('age').value = employee.Age;

            // Assuming you have a hidden field to store the employee ID
            document.getElementById('employeeId').value = id;
        })
        .catch(error => console.error('Error fetching employee details:', error));
}