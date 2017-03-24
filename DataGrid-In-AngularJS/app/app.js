var app = angular.module('angularTable', ['angularUtils.directives.dirPagination']);

app.controller('listdata',function($http){
	var self = this;
	
	self.users = []; //初始化空数组
	self.pageno = 1; // 当前页默认为 1
	self.total_count = 0;
	self.itemsPerPage = 10; //可以绑定到下拉框列表
	
	self.getData = function(pageno){ 
		
		self.users = [];
		self.pageno = pageno;
	   
		$http({
		    method: 'post',
		    url: '/API/DataGrid',
		    data: { pagesize: self.itemsPerPage, pageno: self.pageno }
		}).success(function (response) {

			self.users = response.data;  
			self.total_count = response.total_count;
		});
	};
	
	self.getData(self.pageno); 
	
});