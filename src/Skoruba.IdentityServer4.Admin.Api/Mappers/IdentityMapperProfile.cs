﻿using AutoMapper;
using Skoruba.IdentityServer4.Admin.Api.Dtos.Roles;
using Skoruba.IdentityServer4.Admin.Api.Dtos.Users;
using Skoruba.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity;

namespace Skoruba.IdentityServer4.Admin.Api.Mappers
{
    public class IdentityMapperProfile<TRoleDto, TUserRolesDto, TKey, TUserClaimsDto, TUserClaimDto, TUserProviderDto, TUserProvidersDto, TUserChangePasswordDto, TRoleClaimDto, TRoleClaimsDto> : Profile
        where TUserClaimsDto : UserClaimsDto<TKey>
        where TUserClaimDto : UserClaimDto<TKey>
        where TRoleDto : RoleDto<TKey>
        where TUserRolesDto : UserRolesDto<TRoleDto, TKey>
        where TUserProviderDto : UserProviderDto<TKey>
        where TUserProvidersDto : UserProvidersDto<TKey>
        where TUserChangePasswordDto : UserChangePasswordDto<TKey>
        where TRoleClaimsDto : RoleClaimsDto<TKey>
        where TRoleClaimDto : RoleClaimDto<TKey>
    {
        public IdentityMapperProfile()
        {
            // entity to model
            CreateMap<TUserClaimsDto, UserClaimsApiDto<TKey>>(MemberList.Destination);
            CreateMap<TUserClaimsDto, UserClaimApiDto<TKey>>(MemberList.Destination);

            CreateMap<UserClaimApiDto<TKey>, TUserClaimsDto>(MemberList.Source);
            CreateMap<TUserClaimDto, UserClaimApiDto<TKey>>(MemberList.Destination);

            CreateMap<TUserRolesDto, UserRolesApiDto<TRoleDto>>(MemberList.Destination);
            CreateMap<UserRoleApiDto<TKey>, TUserRolesDto>(MemberList.Destination);

            CreateMap<TUserProviderDto, UserProviderApiDto<TKey>>(MemberList.Destination);
            CreateMap<TUserProvidersDto, UserProvidersApiDto<TKey>>(MemberList.Destination);
            CreateMap<UserProviderDeleteApiDto<TKey>, TUserProviderDto>(MemberList.Source);

            CreateMap<UserChangePasswordApiDto<TKey>, TUserChangePasswordDto>(MemberList.Destination);

            CreateMap<RoleClaimsApiDto<TKey>, TRoleClaimsDto>(MemberList.Source);
            CreateMap<RoleClaimApiDto<TKey>, TRoleClaimDto>(MemberList.Destination);
            CreateMap<RoleClaimApiDto<TKey>, TRoleClaimsDto>(MemberList.Destination);

            CreateMap<TRoleClaimsDto, RoleClaimsApiDto<TKey>>(MemberList.Source);
            CreateMap<TRoleClaimDto, RoleClaimApiDto<TKey>>(MemberList.Destination);
            CreateMap<TRoleClaimsDto, RoleClaimApiDto<TKey>>(MemberList.Destination);
        }
    }
}