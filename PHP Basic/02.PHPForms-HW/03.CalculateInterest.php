<!DOCTYPE html>
<html>
    <head>
        <title></title>
    </head>
    <body>
        <form method="post">
            <span>Enter Amount</span>
            <input type="text" name="amount"/><br />
            <input type="radio" name="valute" value="us"/>USD
            <input type="radio" name="valute" value="eu"/>EUR
            <input type="radio" name="valute" value="bg"/>BGN<br />
            <span>Compound Interest Amount</span>
            <input type="text" name="comAm"/><br />
            <select name="period">
                <option value="0,5">6 Months</option>
                <option value="1">1 Year</option>
                <option value="2">2 Years</option>
                <option value="5">5 Years</option>
            </select>
            <input type="submit" value="Submit" />
            <?php header("Content-Type: text/html; charset=utf8"); ?>
            <?php
            if(isset($_POST['amount'])){
                $period= floatval($_POST["period"]);
                if($period=='1/2') $period=0.5;
                $amount=floatval($_POST["amount"]);
                $comInt=floatval($_POST["comAm"]/100);
                $final=$amount*pow((1+$comInt/12),12*$period);
                $val = $_POST['valute'];
                switch($val){
                    case "us":echo '$'.number_format($final, 2, '.', ''); break;
                    case "bg":echo number_format($final, 2, '.', '').'??.'; break;
                    case "eu":echo '&euro;'.number_format($final, 2, '.', ''); break;
                }
            }
            ?>
        </form>
    </body>
</html>