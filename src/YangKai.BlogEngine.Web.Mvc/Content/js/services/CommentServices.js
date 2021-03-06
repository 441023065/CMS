﻿
angular.module("CommentServices", ["ngResource"]).factory("Comment", [
  '$resource', function($resource) {
    return $resource("/odata/Comment:id/:action", {
      id: '@id',
      action: '@action'
    }, {
      recent: {
        method: "GET",
        params: {
          action: "recent"
        }
      },
      del: {
        method: "POST",
        params: {
          action: 'delete'
        }
      },
      renew: {
        method: "POST",
        params: {
          action: 'renew'
        }
      },
      remove: {
        method: "POST",
        params: {
          action: 'Remove'
        }
      },
      recover: {
        method: "POST",
        params: {
          action: 'Recover'
        }
      }
    });
  }
]);
