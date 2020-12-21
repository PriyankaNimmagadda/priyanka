function DiffInDays() {
    var date1 = new Date('11/21/2020');
    var date2 = new Date('11/23/2020');
    var result_dateInTime = Math.abs(date2.getTime() - date1.getTime());
    var result_dateInDays = result_dateInTime / (1000 * 60 * 60 * 24);
    console.log("Date1:" + date1, "Date2: " + date2, "Diff in time:" + result_dateInTime, "diff in days:" + result_dateInDays);
}
DiffInDays();
