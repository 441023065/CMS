﻿var AdminCategoryController;

AdminCategoryController = [
  "$scope", "$dialog", "$routeParams", "Category", "Group", function($scope, $dialog, $routeParams, Category, Group) {
    var load;
    $scope.loading = true;
    Group.query({
      $filter: "Url eq '" + $routeParams.group + "'",
      $expand: 'Channel'
    }, function(data) {
      return $scope.group = data.value[0];
    });
    load = function() {
      return Category.query({
        $filter: "IsDeleted eq false and Group/Url eq '" + $routeParams.group + "'"
      }, function(data) {
        $scope.list = data;
        return $scope.loading = false;
      });
    };
    $scope.add = function() {
      $scope.entity = {};
      return $scope.editDialog = true;
    };
    $scope.edit = function(item) {
      $scope.entity = angular.copy(item);
      return $scope.editDialog = true;
    };
    $scope.save = function() {
      $scope.entity.Group = $scope.group;
      if ($scope.entity.CategoryId) {
        return Category.edit({
          id: "(guid'" + $scope.entity.CategoryId + "')"
        }, $scope.entity, function(data) {
          message.success("Edit category successfully.");
          $scope.close();
          return load();
        });
      } else {
        debugger;
        $scope.entity.CategoryId = UUID.generate();
        return Category.save($scope.entity, function(data) {
          message.success("Add category successfully.");
          $scope.close();
          return load();
        });
      }
    };
    $scope.remove = function(item) {
      return message.confirm(function() {
        item.IsDeleted = true;
        return Category.edit({
          id: "(guid'" + item.CategoryId + "')"
        }, item, function(data) {
          message.success("Delete category successfully.");
          return load();
        });
      });
    };
    $scope.close = function() {
      return $scope.editDialog = false;
    };
    return load();
  }
];
