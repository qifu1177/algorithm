<?php
class Solution {

    /**
     * @param Integer[] $nums
     * @return Integer
     */
    function firstMissingPositive($nums) {
        $temp=array();
        $n=count($nums);
        for($i=0;$i<$n;$i++){
            if($nums[$i]>0 && $nums[$i]<=$n)
                $temp[$nums[$i]-1]=$nums[$i];
        }
        for($i=0;$i<$n;$i++){
            if(array_key_exists($i,$temp))
                continue;
            else
                return $i+1;
        }
        return $n+1;
    }
}
$sol=new Solution();
$arr = array(1,2,0);
$resul=$sol->firstMissingPositive($arr);
echo "---".$resul."\n"; 
$arr = array(3,4,-1,1);
$resul=$sol->firstMissingPositive($arr);
echo "---".$resul."\n"; 
$arr = array(7,8,9,11,12);
$resul=$sol->firstMissingPositive($arr);
echo "---".$resul."\n"; 
?>