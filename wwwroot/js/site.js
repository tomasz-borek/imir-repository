// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementsByClassName("navbar-toggle")[0].addEventListener("click", classToggle);
var clockElement = document.getElementById("clock");

function nameSearch() {
	// Declare variables
	var input, filter, table, tr, td, i, txtValue;
	input = document.getElementById("name-input");
	filter = input.value.toUpperCase();
	table = document.getElementById("resolution-table");
	tr = table.getElementsByTagName("tr");

	// Loop through all table rows, and hide those who don't match the search query
	for (i = 1; i < tr.length; i++) {
		td = tr[i].getElementsByTagName("td")[0];
		if (td) {
			txtValue = td.textContent || td.innerText;
			if (txtValue.toUpperCase().indexOf(filter) > -1) {
				tr[i].style.display = "";
			} else {
				tr[i].style.display = "none";
			}
		}
	}
	document.getElementsByClassName("inputs-row")[0].style.display = ""
}

function descriptionSearch() {
	// Declare variables
	var input, filter, table, tr, td, i, txtValue;
	input = document.getElementById("description-input");
	filter = input.value.toUpperCase();
	table = document.getElementById("resolution-table");
	tr = table.getElementsByTagName("tr");

	// Loop through all table rows, and hide those who don't match the search query
	for (i = 1; i < tr.length; i++) {
		td = tr[i].getElementsByTagName("td")[1];
		if (td) {
			txtValue = td.textContent || td.innerText;
			if (txtValue.toUpperCase().indexOf(filter) > -1) {
				tr[i].style.display = "";
			} else {
				tr[i].style.display = "none";
			}
		}
	}
	document.getElementsByClassName("inputs-row")[0].style.display = ""
}

function dateSearch() {
	// Declare variables
	var input, filter, table, tr, td, i, txtValue;
	input = document.getElementById("date-input");
	filter = input.value.toUpperCase();
	table = document.getElementById("resolution-table");
	tr = table.getElementsByTagName("tr");

	// Loop through all table rows, and hide those who don't match the search query
	for (i = 1; i < tr.length; i++) {
		td = tr[i].getElementsByTagName("td")[2];
		if (td) {
			txtValue = td.textContent || td.innerText;
			if (txtValue.toUpperCase().indexOf(filter) > -1) {
				tr[i].style.display = "";
			} else {
				tr[i].style.display = "none";
			}
		}
	}
	document.getElementsByClassName("inputs-row")[0].style.display = ""
}

function classToggle() {
	const navs = document.getElementsByClassName("navbar-item");

	for (i = 0; i < navs.length; i++) {
		navs[i].classList.toggle("show-navbar");
	}
}

(function () {

	var clock = document.getElementById( "clock" );
  
	function updateClock ( clock ) {
	  clock.innerHTML = new Date().toLocaleTimeString();
	}
  
	setInterval(function () {
		updateClock( clock );
	}, 1000);
  
  }());
