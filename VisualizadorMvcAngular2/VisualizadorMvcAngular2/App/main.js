﻿(function () {
    'use strict';

    angular
        .module('app')
        .controller('Main', main);

    function main() {
        var vm = this;
        vm.sobrenome = 'Lopes';
    }

})();