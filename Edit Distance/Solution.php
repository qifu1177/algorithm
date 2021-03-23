<?php
class Solution {

    /**
     * @param String $word1
     * @param String $word2
     * @return Integer
    
     */
    private $dic=array();
    function minDistance($word1, $word2) {
        array_splice($this->dic,0);      
        return $this->caculate($word1,$word2,strlen($word1)-1,strlen($word2)-1);
    }
    function caculate($word1,$word2,$w1Index,$w2Index){
        $key="".$w2Index.".".$w1Index;
        if(array_key_exists($key,$this->dic))
            return $this->dic[$key];
        if($w1Index<0)
            return $w2Index+1;
        if($w2Index<0)
            return $w1Index+1;
        if($word1[$w1Index]==$word2[$w2Index])
            return $this->dic[$key]=$this->caculate($word1,$word2,$w1Index-1,$w2Index-1);        
        else{            
            $this->dic[$key]= 1+min($this->caculate($word1,$word2,$w1Index-1,$w2Index),
            $this->caculate($word1,$word2,$w1Index,$w2Index-1),
            $this->caculate($word1,$word2,$w1Index-1,$w2Index-1));
        }
        return $this->dic[$key];
    }
    
}
$sol=new Solution();

$resul=$sol->minDistance("horse",  "ros");
echo "---".$resul."\n"; 

$resul=$sol->minDistance("intention", "execution");
echo "---".$resul."\n";
$resul=$sol->minDistance("dinitrophenylhydrazine", 'benzalphenylhydrazone');
echo "---".$resul."\n";
$resul=$sol->minDistance("dinitrophenylhydrazine", 'acetylphenylhydrazine');
echo "---".$resul."\n";
$resul=$sol->minDistance("mart", 'karma');
echo "---".$resul."\n";
$resul=$sol->minDistance("abcdxabcde", 'abcdeabcdx');
echo "---".$resul."\n";
?>