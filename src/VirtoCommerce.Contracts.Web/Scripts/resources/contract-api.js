angular.module('Contracts')
    .factory('Contracts.api', ['$resource', function ($resource) {
        return $resource('api/contracts/', {}, {
            getContract: { method: 'GET', url: 'api/contracts/:id' },
            searchContracts: { method: 'POST', url: 'api/contracts/search' },
            createContract: { method: 'POST' },
            updateContract: { method: 'PUT' },
            deleteContract: { method: 'DELETE' }
        })
    }])
    .factory('Contracts.membersApi', ['$resource', function ($resource) {
        return $resource('api/contracts/members/', {}, {
            searchContractMembers: { method: 'POST', url: 'api/contracts/members/search' },
            addContractMembers: { method: 'POST', url: 'api/contracts/members/add' },
            deleteContractMembers: { method: 'POST', url: 'api/contracts/members/delete' }
        })
    }])
    .factory('Contracts.pricesApi', ['$resource', function ($resource) {
        return $resource('api/contracts/prices/', {}, {
            searchContractPrices: { method: 'POST', url: 'api/contracts/prices/search' },
            getContractProductPrices: { method: 'POST', url: 'api/contracts/prices/search/products', isArray: true },
            linkPricelistMembers: { method: 'POST', url: 'api/contracts/prices/linkpricelist' },
            saveContractPrices: { method: 'POST', url: 'api/contracts/prices/products' },
            restoreContractPrices: { method: 'POST', url: 'api/contracts/prices/restore' }
        })
    }]);
