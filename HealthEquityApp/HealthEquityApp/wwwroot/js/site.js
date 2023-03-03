
// Performs a post request to API to verify the user guessing
$(".btn_guess").on('click', function () {
    const baseApiUrl = "/api/guessvalue";

    const idBtn = $(this).attr("id");
    const carId = idBtn.replace("btn_", "");
    const idGuessInput = "#input_" + carId;
    const guessValue = $(idGuessInput).val();

    const carMake = $("#carmake_" + carId).text();
    const carModel = $("#carmodel_" + carId).text();
    const carYear = $("#caryear_" + carId).text();

    const modalTitle = `${carMake} ${carModel} - Year ${carYear}`;

    $(".modal-title").text(modalTitle);
    $(".guess-value").text(guessValue);

    if ($.trim(guessValue) !== "") {
        const urlRequest = `${baseApiUrl}/${carId}/${guessValue}`;

        $.post(urlRequest, function (data) {
            if (data)
                $("#modal_success").modal("show");
            else
                $("#modal_fail").modal("show");
        });
    }
});