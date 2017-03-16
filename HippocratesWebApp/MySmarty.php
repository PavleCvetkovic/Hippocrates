<?php

require("smarty/libs/Smarty.class.php");

class MySmarty extends Smarty {
    function __construct() {
        // Class Constructor. These automatically get set with each new instance.
        parent::__construct();

        $this->template_dir ="tpl/";
        $this->compile_dir = "smarty/templates_c/";
        $this->config_dir = "smarty/conf/";
        $this->cache_dir = "smarty/cache/";

        $this->left_delimiter="[[";
        $this->right_delimiter="]]";

    }

}

?>