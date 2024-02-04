<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task2.aspx.cs" Inherits="Implementations.Task2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        table thead tr td,
        table tbody tr td {
            white-space: nowrap;
            overflow: hidden;
        }
    </style>
    <section class="content ecommerce-page">
        <div class="block-header">
            <div class="row">
                <div class="col-lg-7 col-md-6 col-sm-12">
                    <h2>Contact Enquiry </h2>
                </div>
                <div class="col-lg-5 col-md-6 col-sm-12">
                    <ul class="breadcrumb float-md-right">
                        <li class="breadcrumb-item">
                            <a href="Admindashboard.aspx"><i class="zmdi zmdi-home"></i>Dashboard</a>
                        </li>
                        <li class="breadcrumb-item active">Contact Enquiry </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="container-fluid">
            <div class="row clearfix">
                <div class="col-lg-12">
                    <div class="card product_item_list">
                        <div class="body table-responsive">
                            <table class="table table-hover m-b-0">
                                <thead>
                                    <tr>
										<th>Sr. No</th>
                                        <th>Application Type</th>
                                        <th>Name</th>
                                        <th>Email</th>
                                        <th>Phone</th>
                                        <th>Nature Business</th>
                                        <th>Food Category</th>
                                        <th>Designition</th>
                                        <th>Address</th>
                                        <th>AreaLocality</th>
                                        <th>City</th>
                                        <th>District</th>
                                        <th>State</th>
                                        <th>PinCode</th>
                                        <th>NoYears</th>
                                        <th>Apply Date</th>



                                        <th data-breakpoints="sm xs md">Delete</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="BindEnqDeital" runat="server">
                                        <ItemTemplate>
                                            <tr>
												 <td> <%# Container.ItemIndex + 1 %></td>
                                                 <td><%# Eval("ATType") %></td>
                                                <td><%# Eval("Name") %></td>
                                                <td><%# Eval("Email") %></td>
                                                <td><%# Eval("Phone") %></td>
                                                <td><%# Eval("NatureBusiness") %></td>
                                                <td><%# Eval("FoodCategory") %></td>
                                                <td><%# Eval("Designition") %></td>
                                                <td><%# Eval("Address") %></td>
                                                <td><%# Eval("AreaLocality") %></td>
                                                <td><%# Eval("City") %></td>
                                                <td><%# Eval("District") %></td>
                                                <td><%# Eval("State") %></td>
                                                <td><%# Eval("PinCode") %></td>
                                                <td><%# Eval("NoYears") %></td>
                                                <td><%# Eval("CurrentDate") %></td>

                                                <td>
                                                    <%-- <a href="javascript:void(0);" class="btn btn-default waves-effect waves-float waves-green"><i class="zmdi zmdi-edit"></i></a>---%>
                                                    <a href="AdminHomeEnquiryDelete.aspx?id=<%# Eval("ContactEnquiryId") %>" class="btn btn-default waves-effect waves-float waves-red"><i class="zmdi zmdi-delete"></i></a>
                                                </td>
                                            </tr>
                                        </ItemTemplate>

                                    </asp:Repeater>


                                </tbody>
                            </table>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </section>
</asp:Content>


