
// Performs a post request to API to verify the user guessing
$(".btn_guess").on('click', function () {
    const baseApiUrl = "/api/guessvalue";

    // Get car id and the value entered in the input tag
    const btnId = $(this).attr("id");
    const carId = idBtn.replace("btn_", "");
    const userGuessNumber = getGuessValue(carId);

    // Clear the input value
    $(idGuessInput).val('');

    // Get car info
    const carInfo = getCarInfo(carId);
    const modalTitle = `${carInfo.carMake} ${carInfo.carModel} - Year ${carInfo.carYear}`;

    // Change the text in the modals
    $(".modal-title").text(modalTitle);
    $(".guess-value").text(praseInt(userGuessNumber).toLocaleString());

    if ($.trim(userGuessNumber) !== "") {
        const urlRequest = `${baseApiUrl}/${carId}/${guessValue}`;

        $.post(urlRequest, function (data) {
            if (data)            
                $("#modal_success").modal("show"); // Guess value within range
            else
                $("#modal_fail").modal("show"); // Guess value not in range
        });
    }
});

// Get the value entered in the input tag
function getGuessValue(carId) {    
    const idGuessInput = "#input_" + carId;
    return $(idGuessInput).val();    
}

function getCarInfo(carId) {
    const carMake = $("#carmake_" + carId).text();
    const carModel = $("#carmodel_" + carId).text();
    const carYear = $("#caryear_" + carId).text();

    return { "carMake": carMake, "carModel": carModel, "carYear": carYear };
}