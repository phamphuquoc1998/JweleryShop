



$(() => {
    let connection = new signalR.HubConnectionBuilder().withUrl("/signalServer").build();

    connection.start();

    connection.on("refreshProducts", function () {
        loadData1();
    });

    loadData1();

    function loadData1() {
        var tr = '';

        $.ajax({
            url: 'Admin/LoaiSanPham/Layloaisanphams',
            method: 'GET',
            success: (result) => {
                $.each(result, (k, v) => {
                   
                    tr = tr + `<tr class="text-center">
                    <td>${v.maLSP} </td>
                    <td>${v.tenLSP}</td>                    
                    <td><img src="/imgs/menuProducts/${v.hinhAnh}" width="220" height="48" /></td>
                    <td>${v.moTa}</td>
                   
                    <td><a class="btn btn-outline-danger" href='Admin/LoaiSanPham/Delete/${v.maLSP}'><i class='fa fa-trash-o'></i> </a></td>
                    <td><a class="btn btn-outline-primary" href='Admin/LoaiSanPham/Edit/${v.maLSP}'><i class='fa fa-edit'></i></a></td>

                </tr>`;
                });

                $("#tableBody").html(tr);
            },
            error: (error) => {
                console.log(error);
            }
        });
    }
});